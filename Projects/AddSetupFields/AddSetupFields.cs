using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;
using AddSetupFields;

// TODO: Replace the following version attributes by creating AssemblyInfo.cs. You can do this in the properties of the Visual Studio project.
[assembly: AssemblyVersion("1.2.0")]
[assembly: AssemblyFileVersion("1.2.0")]
[assembly: AssemblyInformationalVersion("1.0")]

// TODO: Uncomment the following line if the script requires write access.
[assembly: ESAPIScript(IsWriteable = true)]

namespace VMS.TPS
    {
    public class Script
    {
        public Script()
        {
        }

        private static void NameCBCT(string planName, Beam beam)
        {
            if (planName.Length > 11)
            {
                planName = planName.Substring(0, 11).Trim();
            }

            beam.Id = "CBCT " + planName;
        }

        private static void NameKV(string planName, Beam beam, PatientOrientation orientation)
        {
            if (planName.Length > 11)
            {
                planName = planName.Substring(0, 11).Trim();
            }

            if (orientation.ToString() == "HeadFirstSupine")
            {
                ControlPointCollection cp = beam.ControlPoints;
                switch (cp[0].GantryAngle)
                {
                    case 0:
                        beam.Id = "APSU " + planName;
                        break;
                    case 90:
                        beam.Id = "LLSU " + planName;
                        break;
                    case 270:
                        beam.Id = "RLSU " + planName;
                        break;
                    case 180:
                        beam.Id = "PASU " + planName;
                        break;
                    default:
                        break;
                }
            }

            if (orientation.ToString() == "HeadFirstProne")
            {
                ControlPointCollection cp = beam.ControlPoints;
                switch (cp[0].GantryAngle)
                {
                    case 0:
                        beam.Id = "PASU " + planName;
                        break;
                    case 90:
                        beam.Id = "RLSU " + planName;
                        break;
                    case 270:
                        beam.Id = "LLSU " + planName;
                        break;
                    case 180:
                        beam.Id = "APSU " + planName;
                        break;
                    default:
                        break;
                }
            }

            if (orientation.ToString() == "FeetFirstSupine")
            {
                ControlPointCollection cp = beam.ControlPoints;
                switch (cp[0].GantryAngle)
                {
                    case 0:
                        beam.Id = "APSU " + planName;
                        break;
                    case 90:
                        beam.Id = "RLSU " + planName;
                        break;
                    case 270:
                        beam.Id = "LLSU " + planName;
                        break;
                    case 180:
                        beam.Id = "PASU " + planName;
                        break;
                    default:
                        break;
                }
            }

            if (orientation.ToString() == "FeetFirstProne")
            {
                ControlPointCollection cp = beam.ControlPoints;
                switch (cp[0].GantryAngle)
                {
                    case 0:
                        beam.Id = "PASU " + planName;
                        break;
                    case 90:
                        beam.Id = "LLSU " + planName;
                        break;
                    case 270:
                        beam.Id = "RLSU " + planName;
                        break;
                    case 180:
                        beam.Id = "APSU " + planName;
                        break;
                    default:
                        break;
                }
            }
        }

        private static void NameProneKV(string planName, Beam setupBeam, PatientOrientation orientation)
        {
            if (planName.Length > 10)
            {
                planName = planName.Substring(0, 10).Trim();
            }

            if (orientation.ToString() == "HeadFirstSupine")
            {
                if (setupBeam.ControlPoints[0].GantryAngle > 0 && setupBeam.ControlPoints[0].GantryAngle < 90)
                {
                    setupBeam.Id = "LAOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle > 90 && setupBeam.ControlPoints[0].GantryAngle < 180)
                {
                    setupBeam.Id = "LPOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle > 180 && setupBeam.ControlPoints[0].GantryAngle < 270)
                {
                    setupBeam.Id = "RPOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle > 270 && setupBeam.ControlPoints[0].GantryAngle < 360)
                {
                    setupBeam.Id = "RAOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 0)
                {
                    setupBeam.Id = "APSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 90)
                {
                    setupBeam.Id = "LLSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 180)
                {
                    setupBeam.Id = "PASU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 270)
                {
                    setupBeam.Id = "RLSU " + planName;
                }
            }

            if (orientation.ToString() == "HeadFirstProne")
            {
                if (setupBeam.ControlPoints[0].GantryAngle > 0 && setupBeam.ControlPoints[0].GantryAngle < 90)
                {
                    setupBeam.Id = "RPOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle > 90 && setupBeam.ControlPoints[0].GantryAngle < 180)
                {
                    setupBeam.Id = "RAOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle > 180 && setupBeam.ControlPoints[0].GantryAngle < 270)
                {
                    setupBeam.Id = "LAOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle > 270 && setupBeam.ControlPoints[0].GantryAngle < 360)
                {
                    setupBeam.Id = "LPOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 0)
                {
                    setupBeam.Id = "PASU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 90)
                {
                    setupBeam.Id = "RLSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 180)
                {
                    setupBeam.Id = "APSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 270)
                {
                    setupBeam.Id = "LLSU " + planName;
                }
            }

            if (orientation.ToString() == "FeetFirstSupine")
            {
                if (setupBeam.ControlPoints[0].GantryAngle > 0 && setupBeam.ControlPoints[0].GantryAngle < 90)
                {
                    setupBeam.Id = "RAOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle > 90 && setupBeam.ControlPoints[0].GantryAngle < 180)
                {
                    setupBeam.Id = "RPOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle > 180 && setupBeam.ControlPoints[0].GantryAngle < 270)
                {
                    setupBeam.Id = "LPOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle > 270 && setupBeam.ControlPoints[0].GantryAngle < 360)
                {
                    setupBeam.Id = "LAOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 0)
                {
                    setupBeam.Id = "APSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 90)
                {
                    setupBeam.Id = "RLSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 180)
                {
                    setupBeam.Id = "PASU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 270)
                {
                    setupBeam.Id = "LLSU " + planName;
                }
            }

            if (orientation.ToString() == "FeetFirstProne")
            {
                if (setupBeam.ControlPoints[0].GantryAngle > 0 && setupBeam.ControlPoints[0].GantryAngle < 90)
                {
                    setupBeam.Id = "LPOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle > 90 && setupBeam.ControlPoints[0].GantryAngle < 180)
                {
                    setupBeam.Id = "LAOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle > 180 && setupBeam.ControlPoints[0].GantryAngle < 270)
                {
                    setupBeam.Id = "RAOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle > 270 && setupBeam.ControlPoints[0].GantryAngle < 360)
                {
                    setupBeam.Id = "RPOSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 0)
                {
                    setupBeam.Id = "PASU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 90)
                {
                    setupBeam.Id = "LLSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 180)
                {
                    setupBeam.Id = "APSU " + planName;
                }
                else if (setupBeam.ControlPoints[0].GantryAngle == 270)
                {
                    setupBeam.Id = "RLSU " + planName;
                }
            }           
        }

        private double CalculateFieldArea(ControlPoint cp)
        {
            double[] BankA = new double[60];
            double[] BankB = new double[60];

            for (int i = 0; i < 120; i++)
            {
                if (i < 60)
                {
                    BankA[i] = cp.LeafPositions[0, i] / 10;
                }

                if (i >= 60)
                {
                    BankB[i - 60] = cp.LeafPositions[1, i - 60] / 10;
                }
            }

            double area = 0;
            double[] gaps = new double[60];
            for (int i = 0; i < BankA.Length; i++)
            {
                gaps[i] = BankB[i] - BankA[i];
                if (i > 9 && i < 50)
                {
                    area += gaps[i] * 0.5;
                }
                else
                {
                    area += gaps[i] * 1;
                }
            }

            return area;
        }


        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Execute(ScriptContext context /*, System.Windows.Window window, ScriptEnvironment environment*/)
        {
            #region Establish Context
            Patient patient = context.Patient;
            PatientOrientation imageOrientation = context.Image.ImagingOrientation;

            ExternalPlanSetup plan = context.ExternalPlanSetup;

            if (plan == null)
            {
                MessageBox.Show("A plan must be opened in the context window before adding setup fields");
                return;
            }
            #endregion

            #region Reconcile treatment orientation with CT orientation if they are different
            PatientOrientation txOrientation = plan.TreatmentOrientation;

            //If tx plan orientation disagrees with CT image orientation, then validate with user the tx plan orientation
            if (imageOrientation != txOrientation)
            {
                MessageBoxResult result = MessageBox.Show
                    (
                        "The CT image orientation does not agree with the treatment plan orientation. Are you sure the patient orientation in the treatment plan is correct?",
                        "Patient orientation",
                        MessageBoxButton.YesNo
                    );
                if (result == MessageBoxResult.No)
                {
                    MessageBox.Show("Please verify the patient orientation in the treatment plan before continuing.");
                    return;
                }
            }
            #endregion

            #region Get necessary parameters from treatment field
            IEnumerable<Beam> beamsEnum = plan.Beams;

            List<Beam> beamsList = beamsEnum.ToList();
            if (beamsList.Count == 0)
            {
                MessageBox.Show("Plan must have at least one treatment field before adding setup fields.");
                return;
            }

            VVector iso = beamsList[0].IsocenterPosition;
            ExternalBeamTreatmentUnit machine = beamsList[0].TreatmentUnit;
            #endregion

            patient.BeginModifications();

            #region GUI
            //Showing the GUI window to allow user to select DRR parameters
            DRRWindow window = new DRRWindow();
            window.ShowDialog();
            string drrParameters = window.DRRparameters;
            bool prone = window.Prone;

            if (drrParameters == null)
            {
                return;
            }
            #endregion

            #region Add Setup Fields
            ExternalBeamMachineParameters parameters = new ExternalBeamMachineParameters(machine.Id, "6X", 600, "STATIC", null);

            //Adding beams to plan
            Beam CBCT = plan.AddSetupBeam(parameters, new VRect<double>(-100, -100, 100, 100), 0, 0, 0, iso);
            Beam G0 = plan.AddSetupBeam(parameters, new VRect<double>(-100, -100, 100, 100), 0, 0, 0, iso);
            Beam G90 = plan.AddSetupBeam(parameters, new VRect<double>(-100, -100, 100, 100), 0, 90, 0, iso);
            Beam G180 = plan.AddSetupBeam(parameters, new VRect<double>(-100, -100, 100, 100), 0, 180, 0, iso);
            Beam G270 = plan.AddSetupBeam(parameters, new VRect<double>(-100, -100, 100, 100), 0, 270, 0, iso);
         

            //Naming the setup fields and appending the plan name at the end
            NameCBCT(plan.Id, CBCT);
            NameKV(plan.Id, G0, txOrientation);
            NameKV(plan.Id, G90, txOrientation);
            NameKV(plan.Id, G180, txOrientation);
            NameKV(plan.Id, G270, txOrientation);

            //Defining chest and bone DRR parameters
            DRRCalculationParameters Chest = new DRRCalculationParameters(400);
            Chest.SetLayerParameters(0, 5, 100, 1000);
            Chest.SetLayerParameters(1, 0.5, -450, 150);

            DRRCalculationParameters Bone = new DRRCalculationParameters(400);
            Bone.SetLayerParameters(0, 10, 100, 1000);
            Bone.SetLayerParameters(1, .5, -16, 126);

            //Creating DRR with specified parameters
            if (drrParameters == "Chest")
            {
                CBCT.CreateOrReplaceDRR(Chest);
                G0.CreateOrReplaceDRR(Chest);
                G90.CreateOrReplaceDRR(Chest);
                G180.CreateOrReplaceDRR(Chest);
                G270.CreateOrReplaceDRR(Chest);
            }
            else if (drrParameters == "Bone")
            {
                CBCT.CreateOrReplaceDRR(Bone);
                G0.CreateOrReplaceDRR(Bone);
                G90.CreateOrReplaceDRR(Bone);
                G180.CreateOrReplaceDRR(Bone);
                G270.CreateOrReplaceDRR(Bone);
            }
            #endregion

            //Loop which adds prone setup fields with same treatment parameters at treatment fields
            if (prone == true)
            {
                List<ControlPoint> parentBeams = new List<ControlPoint>();
                List<double> gantryAngles = new List<double>();
                foreach (Beam beam in beamsList)
                {
                    if (beam.ControlPoints.Count > 2)
                    {
                        Dictionary<int, double> subFields = new Dictionary<int, double>();
                        foreach (ControlPoint cp in beam.ControlPoints)
                        {
                            double area = CalculateFieldArea(cp);
                            subFields.Add(cp.Index, area);
                        }

                        int max = subFields.OrderByDescending(x => x.Value).First().Key;
                        parentBeams.Add(beam.ControlPoints[max]);

                        subFields.Clear();
                        
                        foreach (ControlPoint cp in parentBeams)
                        {
                            if (!gantryAngles.Contains(cp.GantryAngle))
                            {
                                gantryAngles.Add(cp.GantryAngle);
                                Beam proneSetup = plan.AddMLCSetupBeam(parameters, cp.LeafPositions, cp.JawPositions, cp.CollimatorAngle, cp.GantryAngle, cp.PatientSupportAngle, iso);
                                NameProneKV(plan.Id, proneSetup, txOrientation);
                                if (drrParameters == "Chest") { proneSetup.CreateOrReplaceDRR(Chest); } else { proneSetup.CreateOrReplaceDRR(Bone); }
                            }
                        }

                        parentBeams.Clear();
                    }
                    else
                    {
                        if (!gantryAngles.Contains(beam.ControlPoints[0].GantryAngle))
                        {
                            gantryAngles.Add(beam.ControlPoints[0].GantryAngle);
                            Beam proneSetup = plan.AddMLCSetupBeam(parameters, beam.ControlPoints[0].LeafPositions, beam.ControlPoints[0].JawPositions, beam.ControlPoints[0].CollimatorAngle,
                                beam.ControlPoints[0].GantryAngle, beam.ControlPoints[0].PatientSupportAngle, iso);

                            NameProneKV(plan.Id, proneSetup, txOrientation);
                            if (drrParameters == "Chest") { proneSetup.CreateOrReplaceDRR(Chest); } else { proneSetup.CreateOrReplaceDRR(Bone); }
                        }
                    }
                }                    
            }

            
            
        }
    }
}
