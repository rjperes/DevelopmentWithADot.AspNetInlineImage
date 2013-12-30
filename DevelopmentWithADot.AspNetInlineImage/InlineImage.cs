using System;
using System.IO;
using System.Web.UI.WebControls;

namespace DevelopmentWithADot.AspNetInlineImage
{
	public class InlineImage : Image
	{
		#region Protected override methods
		protected override void OnInit(EventArgs e)
		{
			String imagePath = this.Context.Server.MapPath(this.ImageUrl);
			String extension = Path.GetExtension(imagePath).Substring(1);
			Byte[] imageData = File.ReadAllBytes(imagePath);

			this.ImageUrl = String.Format("data:image/{0};base64,{1}", extension, Convert.ToBase64String(imageData));

			base.OnInit(e);
		}
		#endregion
	}
}