// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_StandardControls.Screens.iPad.DatePicker {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("DatePickerSimple_iPad")]
	public partial class DatePickerSimple_iPad {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UILabel __mt_lblDate;
		
		private MonoTouch.UIKit.UIDatePicker __mt_pkrDate;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblDate")]
		private MonoTouch.UIKit.UILabel lblDate {
			get {
				this.__mt_lblDate = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblDate")));
				return this.__mt_lblDate;
			}
			set {
				this.__mt_lblDate = value;
				this.SetNativeField("lblDate", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("pkrDate")]
		private MonoTouch.UIKit.UIDatePicker pkrDate {
			get {
				this.__mt_pkrDate = ((MonoTouch.UIKit.UIDatePicker)(this.GetNativeField("pkrDate")));
				return this.__mt_pkrDate;
			}
			set {
				this.__mt_pkrDate = value;
				this.SetNativeField("pkrDate", value);
			}
		}
	}
}
