namespace HouseSystem.ROOT.CIMV2 {
    using System;
    using System.ComponentModel;
    using System.Management;
    using System.Collections;
    using System.Globalization;
    using System.ComponentModel.Design.Serialization;
    using System.Reflection;
    
    
    // Functions ShouldSerialize<PropertyName> are functions used by VS property browser to check if a particular property has to be serialized. These functions are added for all ValueType properties ( properties of type Int32, BOOL etc.. which cannot be set to null). These functions use Is<PropertyName>Null function. These functions are also used in the TypeConverter implementation for the properties to check for NULL value of property so that an empty value can be shown in Property browser in case of Drag and Drop in Visual studio.
    // Functions Is<PropertyName>Null() are used to check if a property is NULL.
    // Functions Reset<PropertyName> are added for Nullable Read/Write properties. These functions are used by VS designer in property browser to set a property to NULL.
    // Every property added to the class for WMI property has attributes set to define its behavior in Visual Studio designer and also to define a TypeConverter to be used.
    // An Early Bound class generated for the WMI class.Win32_Desktop
    public class Desktop : System.ComponentModel.Component {
        
        // Private property to hold the WMI namespace in which the class resides.
        private static string CreatedWmiNamespace = "ROOT\\CIMV2";
        
        // Private property to hold the name of WMI class which created this class.
        private static string CreatedClassName = "Win32_Desktop";
        
        // Private member variable to hold the ManagementScope which is used by the various methods.
        private static System.Management.ManagementScope statMgmtScope = null;
        
        private ManagementSystemProperties PrivateSystemProperties;
        
        // Underlying lateBound WMI object.
        private System.Management.ManagementObject PrivateLateBoundObject;
        
        // Member variable to store the 'automatic commit' behavior for the class.
        private bool AutoCommitProp;
        
        // Private variable to hold the embedded property representing the instance.
        private System.Management.ManagementBaseObject embeddedObj;
        
        // The current WMI object used
        private System.Management.ManagementBaseObject curObj;
        
        // Flag to indicate if the instance is an embedded object.
        private bool isEmbedded;
        
        // Below are different overloads of constructors to initialize an instance of the class with a WMI object.
        public Desktop() {
            this.InitializeObject(null, null, null);
        }
        
        public Desktop(string keyName) {
            this.InitializeObject(null, new System.Management.ManagementPath(Desktop.ConstructPath(keyName)), null);
        }
        
        public Desktop(System.Management.ManagementScope mgmtScope, string keyName) {
            this.InitializeObject(((System.Management.ManagementScope)(mgmtScope)), new System.Management.ManagementPath(Desktop.ConstructPath(keyName)), null);
        }
        
        public Desktop(System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            this.InitializeObject(null, path, getOptions);
        }
        
        public Desktop(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path) {
            this.InitializeObject(mgmtScope, path, null);
        }
        
        public Desktop(System.Management.ManagementPath path) {
            this.InitializeObject(null, path, null);
        }
        
        public Desktop(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            this.InitializeObject(mgmtScope, path, getOptions);
        }
        
        public Desktop(System.Management.ManagementObject theObject) {
            Initialize();
            if ((CheckIfProperClass(theObject) == true)) {
                PrivateLateBoundObject = theObject;
                PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
                curObj = PrivateLateBoundObject;
            }
            else {
                throw new System.ArgumentException("Class name does not match.");
            }
        }
        
        public Desktop(System.Management.ManagementBaseObject theObject) {
            Initialize();
            if ((CheckIfProperClass(theObject) == true)) {
                embeddedObj = theObject;
                PrivateSystemProperties = new ManagementSystemProperties(theObject);
                curObj = embeddedObj;
                isEmbedded = true;
            }
            else {
                throw new System.ArgumentException("Class name does not match.");
            }
        }
        
        // Property returns the namespace of the WMI class.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string OriginatingNamespace {
            get {
                return "ROOT\\CIMV2";
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ManagementClassName {
            get {
                string strRet = CreatedClassName;
                if ((curObj != null)) {
                    if ((curObj.ClassPath != null)) {
                        strRet = ((string)(curObj["__CLASS"]));
                        if (((strRet == null) 
                                    || (strRet == string.Empty))) {
                            strRet = CreatedClassName;
                        }
                    }
                }
                return strRet;
            }
        }
        
        // Property pointing to an embedded object to get System properties of the WMI object.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ManagementSystemProperties SystemProperties {
            get {
                return PrivateSystemProperties;
            }
        }
        
        // Property returning the underlying lateBound object.
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public System.Management.ManagementBaseObject LateBoundObject {
            get {
                return curObj;
            }
        }
        
        // ManagementScope of the object.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public System.Management.ManagementScope Scope {
            get {
                if ((isEmbedded == false)) {
                    return PrivateLateBoundObject.Scope;
                }
                else {
                    return null;
                }
            }
            set {
                if ((isEmbedded == false)) {
                    PrivateLateBoundObject.Scope = value;
                }
            }
        }
        
        // Property to show the commit behavior for the WMI object. If true, WMI object will be automatically saved after each property modification.(ie. Put() is called after modification of a property).
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AutoCommit {
            get {
                return AutoCommitProp;
            }
            set {
                AutoCommitProp = value;
            }
        }
        
        // The ManagementPath of the underlying WMI object.
        [Browsable(true)]
        public System.Management.ManagementPath Path {
            get {
                if ((isEmbedded == false)) {
                    return PrivateLateBoundObject.Path;
                }
                else {
                    return null;
                }
            }
            set {
                if ((isEmbedded == false)) {
                    if ((CheckIfProperClass(null, value, null) != true)) {
                        throw new System.ArgumentException("Class name does not match.");
                    }
                    PrivateLateBoundObject.Path = value;
                }
            }
        }
        
        // Public static scope property which is used by the various methods.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static System.Management.ManagementScope StaticScope {
            get {
                return statMgmtScope;
            }
            set {
                statMgmtScope = value;
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsBorderWidthNull {
            get {
                if ((curObj["BorderWidth"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The BorderWidth property sets the width of the borders around all windows with ad" +
            "justable borders.\nExample: 3.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint BorderWidth {
            get {
                if ((curObj["BorderWidth"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["BorderWidth"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("A short textual description (one-line string) of the CIM_Setting object.")]
        public string Caption {
            get {
                return ((string)(curObj["Caption"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCoolSwitchNull {
            get {
                if ((curObj["CoolSwitch"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The CoolSwitch property indicates whether fasttask switching is turned on. Fast t" +
            "ask switching allows the user to switch between windows using the ALT+TAB keyboa" +
            "rd combination.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool CoolSwitch {
            get {
                if ((curObj["CoolSwitch"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["CoolSwitch"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCursorBlinkRateNull {
            get {
                if ((curObj["CursorBlinkRate"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The CursorBlinkRate property indicates the length of time between successive curs" +
            "or blinks.\nExample: 530.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint CursorBlinkRate {
            get {
                if ((curObj["CursorBlinkRate"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["CursorBlinkRate"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("A textual description of the CIM_Setting object.")]
        public string Description {
            get {
                return ((string)(curObj["Description"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDragFullWindowsNull {
            get {
                if ((curObj["DragFullWindows"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The DragFullWindows property indicates whether the contents of a window are shown" +
            " when a user moves the window.\nValues: TRUE or FALSE. A value of TRUE indicates " +
            "the content of the window is displayed while the user moves the window.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool DragFullWindows {
            get {
                if ((curObj["DragFullWindows"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["DragFullWindows"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsGridGranularityNull {
            get {
                if ((curObj["GridGranularity"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The GridGranularity property indicates the spacing of the grid that windows are b" +
            "ound to on the desktop. This makes organizing windows easier. The spacing is usu" +
            "ally fine enough that the user does not notice it.\nExample: 1.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint GridGranularity {
            get {
                if ((curObj["GridGranularity"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["GridGranularity"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIconSpacingNull {
            get {
                if ((curObj["IconSpacing"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The IconSpacing property specifies the spacing between icons.\nExample: 75")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint IconSpacing {
            get {
                if ((curObj["IconSpacing"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["IconSpacing"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The IconTitleFaceName property indicates the nameof the font used for the names o" +
            "f the icons.\nExample: MS San Serif.")]
        public string IconTitleFaceName {
            get {
                return ((string)(curObj["IconTitleFaceName"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIconTitleSizeNull {
            get {
                if ((curObj["IconTitleSize"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The IconTitleSize property indicates the icon font size.\nExample: 9.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint IconTitleSize {
            get {
                if ((curObj["IconTitleSize"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["IconTitleSize"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsIconTitleWrapNull {
            get {
                if ((curObj["IconTitleWrap"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The IconTitleWrap property indicates whether the icon\'s title text wraps to the n" +
            "ext line.\nValues: TRUE or FALSE. A value of TRUE indicates the title wraps to th" +
            "e next line.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool IconTitleWrap {
            get {
                if ((curObj["IconTitleWrap"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["IconTitleWrap"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Name property indicates the name that identifies the current desktop profile." +
            "\nExample: MainProf")]
        public string Name {
            get {
                return ((string)(curObj["Name"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Pattern property indicates the name of the pattern used as the background for" +
            " the desktop")]
        public string Pattern {
            get {
                return ((string)(curObj["Pattern"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsScreenSaverActiveNull {
            get {
                if ((curObj["ScreenSaverActive"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The ScreenSaverActive property indicates whether the screen saver is active.\nValu" +
            "es: TRUE or FALSE. A value of TRUE indicates the screen saver is active.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool ScreenSaverActive {
            get {
                if ((curObj["ScreenSaverActive"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["ScreenSaverActive"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The ScreenSaverExecutable property indicates the name of the current screen saver" +
            " executable file.\nExample: LOGON.SCR.")]
        public string ScreenSaverExecutable {
            get {
                return ((string)(curObj["ScreenSaverExecutable"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsScreenSaverSecureNull {
            get {
                if ((curObj["ScreenSaverSecure"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The ScreenSaverSecure property determines whether the password is enabled for the" +
            " screen saver.\nValues: TRUE or FALSE.  If TRUE, the screen saver password is ena" +
            "bled.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool ScreenSaverSecure {
            get {
                if ((curObj["ScreenSaverSecure"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["ScreenSaverSecure"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsScreenSaverTimeoutNull {
            get {
                if ((curObj["ScreenSaverTimeout"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The ScreenSaverTimeout property indicates the amount of time that passes before t" +
            "he screen saver starts.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint ScreenSaverTimeout {
            get {
                if ((curObj["ScreenSaverTimeout"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["ScreenSaverTimeout"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The identifier by which the CIM_Setting object is known.")]
        public string SettingID {
            get {
                return ((string)(curObj["SettingID"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Wallpaper property indicates the file name for the wallpaper design on the ba" +
            "ckground of the desktop.\nExample: WINNT.BMP")]
        public string Wallpaper {
            get {
                return ((string)(curObj["Wallpaper"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsWallpaperStretchedNull {
            get {
                if ((curObj["WallpaperStretched"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The WallpaperStretched property indicates whether the wallpaper is stretched to fill the entire screen. Microsoft Plus! must be installed before this option is available.
Values: TRUE and FALSE. A value of TRUE indicates the wallpaper is stretched to fit the entire screen. If FALSE, the wallpaper retains its original dimensions on the desktop background.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool WallpaperStretched {
            get {
                if ((curObj["WallpaperStretched"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["WallpaperStretched"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsWallpaperTiledNull {
            get {
                if ((curObj["WallpaperTiled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The WallpaperTiled property indicates whether the wallpaper is tiled or centered." +
            "\nValues: TRUE or FALSE. A value of TRUE indicates the wallpaper is tiled.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool WallpaperTiled {
            get {
                if ((curObj["WallpaperTiled"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["WallpaperTiled"]));
            }
        }
        
        private bool CheckIfProperClass(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions OptionsParam) {
            if (((path != null) 
                        && (string.Compare(path.ClassName, this.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) == 0))) {
                return true;
            }
            else {
                return CheckIfProperClass(new System.Management.ManagementObject(mgmtScope, path, OptionsParam));
            }
        }
        
        private bool CheckIfProperClass(System.Management.ManagementBaseObject theObj) {
            if (((theObj != null) 
                        && (string.Compare(((string)(theObj["__CLASS"])), this.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) == 0))) {
                return true;
            }
            else {
                System.Array parentClasses = ((System.Array)(theObj["__DERIVATION"]));
                if ((parentClasses != null)) {
                    int count = 0;
                    for (count = 0; (count < parentClasses.Length); count = (count + 1)) {
                        if ((string.Compare(((string)(parentClasses.GetValue(count))), this.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) == 0)) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        
        private bool ShouldSerializeBorderWidth() {
            if ((this.IsBorderWidthNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCoolSwitch() {
            if ((this.IsCoolSwitchNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCursorBlinkRate() {
            if ((this.IsCursorBlinkRateNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDragFullWindows() {
            if ((this.IsDragFullWindowsNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeGridGranularity() {
            if ((this.IsGridGranularityNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeIconSpacing() {
            if ((this.IsIconSpacingNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeIconTitleSize() {
            if ((this.IsIconTitleSizeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeIconTitleWrap() {
            if ((this.IsIconTitleWrapNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeScreenSaverActive() {
            if ((this.IsScreenSaverActiveNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeScreenSaverSecure() {
            if ((this.IsScreenSaverSecureNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeScreenSaverTimeout() {
            if ((this.IsScreenSaverTimeoutNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeWallpaperStretched() {
            if ((this.IsWallpaperStretchedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeWallpaperTiled() {
            if ((this.IsWallpaperTiledNull == false)) {
                return true;
            }
            return false;
        }
        
        [Browsable(true)]
        public void CommitObject() {
            if ((isEmbedded == false)) {
                PrivateLateBoundObject.Put();
            }
        }
        
        [Browsable(true)]
        public void CommitObject(System.Management.PutOptions putOptions) {
            if ((isEmbedded == false)) {
                PrivateLateBoundObject.Put(putOptions);
            }
        }
        
        private void Initialize() {
            AutoCommitProp = true;
            isEmbedded = false;
        }
        
        private static string ConstructPath(string keyName) {
            string strPath = "ROOT\\CIMV2:Win32_Desktop";
            strPath = string.Concat(strPath, string.Concat(".Name=", string.Concat("\"", string.Concat(keyName, "\""))));
            return strPath;
        }
        
        private void InitializeObject(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            Initialize();
            if ((path != null)) {
                if ((CheckIfProperClass(mgmtScope, path, getOptions) != true)) {
                    throw new System.ArgumentException("Class name does not match.");
                }
            }
            PrivateLateBoundObject = new System.Management.ManagementObject(mgmtScope, path, getOptions);
            PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
            curObj = PrivateLateBoundObject;
        }
        
        // Different overloads of GetInstances() help in enumerating instances of the WMI class.
        public static DesktopCollection GetInstances() {
            return GetInstances(null, null, null);
        }
        
        public static DesktopCollection GetInstances(string condition) {
            return GetInstances(null, condition, null);
        }
        
        public static DesktopCollection GetInstances(System.String [] selectedProperties) {
            return GetInstances(null, null, selectedProperties);
        }
        
        public static DesktopCollection GetInstances(string condition, System.String [] selectedProperties) {
            return GetInstances(null, condition, selectedProperties);
        }
        
        public static DesktopCollection GetInstances(System.Management.ManagementScope mgmtScope, System.Management.EnumerationOptions enumOptions) {
            if ((mgmtScope == null)) {
                if ((statMgmtScope == null)) {
                    mgmtScope = new System.Management.ManagementScope();
                    mgmtScope.Path.NamespacePath = "root\\CIMV2";
                }
                else {
                    mgmtScope = statMgmtScope;
                }
            }
            System.Management.ManagementPath pathObj = new System.Management.ManagementPath();
            pathObj.ClassName = "Win32_Desktop";
            pathObj.NamespacePath = "root\\CIMV2";
            System.Management.ManagementClass clsObject = new System.Management.ManagementClass(mgmtScope, pathObj, null);
            if ((enumOptions == null)) {
                enumOptions = new System.Management.EnumerationOptions();
                enumOptions.EnsureLocatable = true;
            }
            return new DesktopCollection(clsObject.GetInstances(enumOptions));
        }
        
        public static DesktopCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition) {
            return GetInstances(mgmtScope, condition, null);
        }
        
        public static DesktopCollection GetInstances(System.Management.ManagementScope mgmtScope, System.String [] selectedProperties) {
            return GetInstances(mgmtScope, null, selectedProperties);
        }
        
        public static DesktopCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition, System.String [] selectedProperties) {
            if ((mgmtScope == null)) {
                if ((statMgmtScope == null)) {
                    mgmtScope = new System.Management.ManagementScope();
                    mgmtScope.Path.NamespacePath = "root\\CIMV2";
                }
                else {
                    mgmtScope = statMgmtScope;
                }
            }
            System.Management.ManagementObjectSearcher ObjectSearcher = new System.Management.ManagementObjectSearcher(mgmtScope, new SelectQuery("Win32_Desktop", condition, selectedProperties));
            System.Management.EnumerationOptions enumOptions = new System.Management.EnumerationOptions();
            enumOptions.EnsureLocatable = true;
            ObjectSearcher.Options = enumOptions;
            return new DesktopCollection(ObjectSearcher.Get());
        }
        
        [Browsable(true)]
        public static Desktop CreateInstance() {
            System.Management.ManagementScope mgmtScope = null;
            if ((statMgmtScope == null)) {
                mgmtScope = new System.Management.ManagementScope();
                mgmtScope.Path.NamespacePath = CreatedWmiNamespace;
            }
            else {
                mgmtScope = statMgmtScope;
            }
            System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
            System.Management.ManagementClass tmpMgmtClass = new System.Management.ManagementClass(mgmtScope, mgmtPath, null);
            return new Desktop(tmpMgmtClass.CreateInstance());
        }
        
        [Browsable(true)]
        public void Delete() {
            PrivateLateBoundObject.Delete();
        }
        
        // Enumerator implementation for enumerating instances of the class.
        public class DesktopCollection : object, ICollection {
            
            private ManagementObjectCollection privColObj;
            
            public DesktopCollection(ManagementObjectCollection objCollection) {
                privColObj = objCollection;
            }
            
            public virtual int Count {
                get {
                    return privColObj.Count;
                }
            }
            
            public virtual bool IsSynchronized {
                get {
                    return privColObj.IsSynchronized;
                }
            }
            
            public virtual object SyncRoot {
                get {
                    return this;
                }
            }
            
            public virtual void CopyTo(System.Array array, int index) {
                privColObj.CopyTo(array, index);
                int nCtr;
                for (nCtr = 0; (nCtr < array.Length); nCtr = (nCtr + 1)) {
                    array.SetValue(new Desktop(((System.Management.ManagementObject)(array.GetValue(nCtr)))), nCtr);
                }
            }
            
            public virtual System.Collections.IEnumerator GetEnumerator() {
                return new DesktopEnumerator(privColObj.GetEnumerator());
            }
            
            public class DesktopEnumerator : object, System.Collections.IEnumerator {
                
                private ManagementObjectCollection.ManagementObjectEnumerator privObjEnum;
                
                public DesktopEnumerator(ManagementObjectCollection.ManagementObjectEnumerator objEnum) {
                    privObjEnum = objEnum;
                }
                
                public virtual object Current {
                    get {
                        return new Desktop(((System.Management.ManagementObject)(privObjEnum.Current)));
                    }
                }
                
                public virtual bool MoveNext() {
                    return privObjEnum.MoveNext();
                }
                
                public virtual void Reset() {
                    privObjEnum.Reset();
                }
            }
        }
        
        // TypeConverter to handle null values for ValueType properties
        public class WMIValueTypeConverter : TypeConverter {
            
            private TypeConverter baseConverter;
            
            private System.Type baseType;
            
            public WMIValueTypeConverter(System.Type inBaseType) {
                baseConverter = TypeDescriptor.GetConverter(inBaseType);
                baseType = inBaseType;
            }
            
            public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type srcType) {
                return baseConverter.CanConvertFrom(context, srcType);
            }
            
            public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) {
                return baseConverter.CanConvertTo(context, destinationType);
            }
            
            public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) {
                return baseConverter.ConvertFrom(context, culture, value);
            }
            
            public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary dictionary) {
                return baseConverter.CreateInstance(context, dictionary);
            }
            
            public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetCreateInstanceSupported(context);
            }
            
            public override PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributeVar) {
                return baseConverter.GetProperties(context, value, attributeVar);
            }
            
            public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetPropertiesSupported(context);
            }
            
            public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValues(context);
            }
            
            public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValuesExclusive(context);
            }
            
            public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValuesSupported(context);
            }
            
            public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) {
                if ((baseType.BaseType == typeof(System.Enum))) {
                    if ((value.GetType() == destinationType)) {
                        return value;
                    }
                    if ((((value == null) 
                                && (context != null)) 
                                && (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false))) {
                        return  "NULL_ENUM_VALUE" ;
                    }
                    return baseConverter.ConvertTo(context, culture, value, destinationType);
                }
                if (((baseType == typeof(bool)) 
                            && (baseType.BaseType == typeof(System.ValueType)))) {
                    if ((((value == null) 
                                && (context != null)) 
                                && (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false))) {
                        return "";
                    }
                    return baseConverter.ConvertTo(context, culture, value, destinationType);
                }
                if (((context != null) 
                            && (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false))) {
                    return "";
                }
                return baseConverter.ConvertTo(context, culture, value, destinationType);
            }
        }
        
        // Embedded class to represent WMI system Properties.
        [TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public class ManagementSystemProperties {
            
            private System.Management.ManagementBaseObject PrivateLateBoundObject;
            
            public ManagementSystemProperties(System.Management.ManagementBaseObject ManagedObject) {
                PrivateLateBoundObject = ManagedObject;
            }
            
            [Browsable(true)]
            public int GENUS {
                get {
                    return ((int)(PrivateLateBoundObject["__GENUS"]));
                }
            }
            
            [Browsable(true)]
            public string CLASS {
                get {
                    return ((string)(PrivateLateBoundObject["__CLASS"]));
                }
            }
            
            [Browsable(true)]
            public string SUPERCLASS {
                get {
                    return ((string)(PrivateLateBoundObject["__SUPERCLASS"]));
                }
            }
            
            [Browsable(true)]
            public string DYNASTY {
                get {
                    return ((string)(PrivateLateBoundObject["__DYNASTY"]));
                }
            }
            
            [Browsable(true)]
            public string RELPATH {
                get {
                    return ((string)(PrivateLateBoundObject["__RELPATH"]));
                }
            }
            
            [Browsable(true)]
            public int PROPERTY_COUNT {
                get {
                    return ((int)(PrivateLateBoundObject["__PROPERTY_COUNT"]));
                }
            }
            
            [Browsable(true)]
            public string[] DERIVATION {
                get {
                    return ((string[])(PrivateLateBoundObject["__DERIVATION"]));
                }
            }
            
            [Browsable(true)]
            public string SERVER {
                get {
                    return ((string)(PrivateLateBoundObject["__SERVER"]));
                }
            }
            
            [Browsable(true)]
            public string NAMESPACE {
                get {
                    return ((string)(PrivateLateBoundObject["__NAMESPACE"]));
                }
            }
            
            [Browsable(true)]
            public string PATH {
                get {
                    return ((string)(PrivateLateBoundObject["__PATH"]));
                }
            }
        }
    }
}
