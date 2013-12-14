using System;
using IntelligentFrameCorrection;
using MediaPortal.Configuration;
using MediaPortal.GUI.Library;
using Action = MediaPortal.GUI.Library.Action;

namespace IntelligentFrameCorrectionUI
{
    [PluginIcons("IntelligentFrameCorrectionUI.Enabled.png", "IntelligentFrameCorrectionUI.Disabled.png")]
    public class FrontendGUI : GUIWindow, ISetupForm //, IRenderLayer
    {
        private const int WINDOW_ID = 240782;
        //private bool _running = false;
        //private int _parentWindowID = 0;
        //private GUIWindow _parentWindow = null;

        #region Implementation of ISetupForm

        public string PluginName()
        {
            return "Intelligent Frame Correction GUI";
        }

        public string Description()
        {
            return "Frontend GUI for Intelligen Frame Correction";
        }

        public string Author()
        {
            return "Martin Rogas a.k.a Marvman";
        }

        public void ShowPlugin()
        {
        }

        public bool CanEnable()
        {
            return true;
        }

        public int GetWindowId()
        {
            return WINDOW_ID;
        }

        public bool DefaultEnabled()
        {
            return true;
        }

        public bool HasSetup()
        {
            return false;
        }

        public bool GetHome(out string strButtonText, out string strButtonImage, out string strButtonImageFocus,
                            out string strPictureImage)
        {
            strButtonText = "I.F.C. Settings";
            strButtonImage = String.Empty;
            strButtonImageFocus = String.Empty;
            strPictureImage = "hover_settings.png";

            if (Preferences.getInstance().isMyPluginsUsed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetID
        {
            get { return WINDOW_ID; }
        }

        #endregion

        #region GUIControls

        [SkinControlAttribute(15)] protected GUISpinControl spinControlScanInterval;
        [SkinControlAttribute(13)] protected GUISpinControl spinControlDetectionCounter;
        [SkinControlAttribute(11)] protected GUISpinControl spinControlMinBrightnessThreshold;
        [SkinControlAttribute(9)] protected GUISpinControl spinControlMaxBrightnessThreshold;
        [SkinControlAttribute(7)] protected GUISpinControl spinControlStabilizer;
        [SkinControlAttribute(3)] protected GUISpinControl spinControlSingleBlackBarHeight;
        [SkinControlAttribute(5)] protected GUISpinControl spinControlDoubleBlackBarHeight;
        [SkinControlAttribute(16)] protected GUICheckButton toggleButtonVerboseLogging;
        //[SkinControlAttribute(9)] protected GUIButtonControl buttonExit;

        #endregion

        public override bool Init()
        {
            bool bResult = Load(GUIGraphicsContext.Skin + @"\IFC_Settings.xml");
            return bResult;
        }

        protected override void OnPageLoad()
        {
            //_parentWindow = GUIWindowManager.GetWindow(GUIWindowManager.GetPreviousActiveWindow());
            loadConfig();
            base.OnPageLoad();
        }

        protected override void OnClicked(int controlId, GUIControl control,
                                          Action.ActionType actionType)
        {
            switch (controlId)
            {
                //case 9: //Exit Button
                //    {
                //        onExit();
                //        break;
                //    }
                
                //Oh my gosh a hack
                case 18: //Scaninterval SpinControl
                    {
                        var guiSpinControl = ((GUISpinControl)control);

                        if (guiSpinControl.SelectedButton == GUISpinControl.SpinSelect.SPIN_BUTTON_DOWN)
                            guiSpinControl.Value -= 99;

                        if (guiSpinControl.SelectedButton == GUISpinControl.SpinSelect.SPIN_BUTTON_UP)
                            guiSpinControl.Value += 99;

                        break;
                    }
            }
            base.OnClicked(controlId, control, actionType);
        }

        public override void OnAction(Action action)
        {
            switch (action.wID)
            {
                case Action.ActionType.ACTION_CONTEXT_MENU:
                    {
                        //GUIDialogMenu dlg = (GUIDialogMenu)GUIWindowManager.GetWindow((int)Window.WINDOW_DIALOG_MENU);
                        //dlg.Add("I.F.C.: Settings");
                        //dlg.DoModal();
                        break;
                    }
                case Action.ActionType.ACTION_PREVIOUS_MENU:
                    {
                        //Utils.log(Preferences.getInstance().verboselogging, "back to previous window");
                        acceptPreferenceValues();
                        Preferences.getInstance().saveConfig(Config.GetFile(Config.Dir.Config,
                                                                            "IntelligentFrameCorrection.xml"));
                        // _running = false;
                        break;
                    }
            }

            base.OnAction(action);
        }

        private void acceptPreferenceValues()
        {
            Preferences prefs = Preferences.getInstance();


            prefs.scanInterval = spinControlScanInterval.Value;
            prefs.stopCounterEnd = spinControlDetectionCounter.Value;
            prefs.minBrightnessTreshold = spinControlMinBrightnessThreshold.Value;
            prefs.maxBrightnessTreshold = spinControlMaxBrightnessThreshold.Value;
            prefs.stabilizationFactor = spinControlStabilizer.Value;
            prefs.singleBlackBarHeight = spinControlSingleBlackBarHeight.Value/100f;
            prefs.doubleBlackBarHeight = spinControlDoubleBlackBarHeight.Value/100f;
            prefs.verboselogging = toggleButtonVerboseLogging.Selected;
        }

        private void loadConfig()
        {
            Preferences prefs = Preferences.getInstance();

            spinControlScanInterval.SetRange(1, 99999);
            spinControlScanInterval.Value = prefs.scanInterval;
            spinControlDetectionCounter.Value = prefs.stopCounterEnd;
            spinControlMinBrightnessThreshold.SetRange(1, 255);
            spinControlMinBrightnessThreshold.Value = prefs.minBrightnessTreshold;
            spinControlMaxBrightnessThreshold.SetRange(1, 255);
            spinControlMaxBrightnessThreshold.Value = prefs.maxBrightnessTreshold;
            spinControlStabilizer.SetRange(1,50);
            spinControlStabilizer.Value = prefs.stabilizationFactor;
            spinControlSingleBlackBarHeight.SetRange(0, 15);
            spinControlSingleBlackBarHeight.Value = (int) (prefs.singleBlackBarHeight*100);
            spinControlDoubleBlackBarHeight.SetRange(0, 30);
            spinControlDoubleBlackBarHeight.Value = (int) (prefs.doubleBlackBarHeight*100);
            toggleButtonVerboseLogging.Selected = prefs.verboselogging;
        }

        //private void onExit()
        //{
        //    GUIWindowManager.IsSwitchingToNewWindow = true;
        //    lock (this)
        //    {
        //        GUIMessage msg = null;
        //        msg = new GUIMessage(GUIMessage.MessageType.GUI_MSG_WINDOW_DEINIT, GetID, 0, 0, 0, 0, null);
        //        OnMessage(msg);

        //        GUIWindowManager.UnRoute();

        //        msg = new GUIMessage(GUIMessage.MessageType.GUI_MSG_WINDOW_INIT, _parentWindow.GetID, 0, 0, -1, 0, null);
        //        OnMessage(msg);

        //        GUIWindowManager.ActivateWindow(_parentWindow.GetID);

        //        _parentWindow = null;
        //    }
        //    GUIWindowManager.IsSwitchingToNewWindow = false;
        //    GUILayerManager.UnRegisterLayer(this);

        //}

        //public void DoModal(int dwParentId)
        //{
        //    _parentWindowID = dwParentId;
        //    _parentWindow = GUIWindowManager.GetWindow(_parentWindowID);
        //    if (null == _parentWindow)
        //    {
        //        _parentWindowID = 0;
        //        return;
        //    }

        //    GUIWindowManager.IsSwitchingToNewWindow = true;
        //    GUIWindowManager.RouteToWindow(GetID);

        //    // activate this window...
        //    GUIMessage msg = new GUIMessage(GUIMessage.MessageType.GUI_MSG_WINDOW_INIT, GetID, 0, 0, -1, 0, null);
        //    OnMessage(msg);

        //    GUIWindowManager.IsSwitchingToNewWindow = false;
        //    _running = true;
        //    GUILayerManager.RegisterLayer(this, GUILayerManager.LayerType.Dialog);
        //    while (_running && GUIGraphicsContext.CurrentState == GUIGraphicsContext.State.RUNNING)
        //    {
        //        GUIWindowManager.Process();
        //    }

        //   onExit();

        //}

        #region Implementation of IRenderLayer

        //public bool ShouldRenderLayer()
        //{
        //    return true;
        //}

        //public void RenderLayer(float timePassed)
        //{
        //    if (_running)
        //    {
        //        Render(timePassed);
        //    }
        //}

        #endregion
    }
}