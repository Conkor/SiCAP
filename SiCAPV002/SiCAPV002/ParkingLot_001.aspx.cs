using SiCAP_GrupoCARARA.App_Business;
using SiCAP_GrupoCARARA.App_Domain;
using SiCAP_GrupoCARARA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiCAP_GrupoCARARA
{
    public partial class ParkingLot_001 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ParkingSpaceTransaction transaction = new ParkingSpaceTransaction();
            List<string> existingSpaces = transaction.PrintExistingSpaces(1);
            printInScreen(existingSpaces);

            User user = new User("julio.verne@ulatina.net");
            populateDDLListOfVehicles(user);


        }

        public void printInScreen(List<string> existingSpaces)
        {
            string message;
            
            if (existingSpaces.Count == 0)
                message = "Este parqueo no posee espacios registrados";
            if (existingSpaces.Count >= 1)
                ParkinSpace001.Visible = true;
            if (existingSpaces.Count >= 2)
                ParkinSpace002.Visible = true;
            if (existingSpaces.Count >= 3)
                ParkinSpace003.Visible = true;
            if (existingSpaces.Count >= 4)
                ParkinSpace004.Visible = true;
            if (existingSpaces.Count >= 5)
                ParkinSpace005.Visible = true;
            if (existingSpaces.Count >= 6)
                ParkinSpace006.Visible = true;
            if (existingSpaces.Count >= 7)
                ParkinSpace007.Visible = true;
            if (existingSpaces.Count >= 8)
                ParkinSpace008.Visible = true;
            if (existingSpaces.Count >= 9)
                ParkinSpace009.Visible = true;
            if (existingSpaces.Count >= 10)
                ParkinSpace010.Visible = true;
            if (existingSpaces.Count >= 11)
                ParkinSpace011.Visible = true;
            if (existingSpaces.Count >= 12)
                ParkinSpace012.Visible = true;
            if (existingSpaces.Count >= 13)
                ParkinSpace013.Visible = true;
            if (existingSpaces.Count >= 14)
                ParkinSpace014.Visible = true;
            if (existingSpaces.Count >= 15)
                ParkinSpace015.Visible = true;
            if (existingSpaces.Count >= 16)
                ParkinSpace016.Visible = true;
            if (existingSpaces.Count >= 17)
                ParkinSpace017.Visible = true;
            if (existingSpaces.Count >= 18)
                ParkinSpace018.Visible = true;
            if (existingSpaces.Count >= 19)
                ParkinSpace019.Visible = true;
            if (existingSpaces.Count >= 20)
                ParkinSpace020.Visible = true;
            if (existingSpaces.Count >= 21)
                ParkinSpace021.Visible = true;
            if (existingSpaces.Count >= 22)
                ParkinSpace022.Visible = true;
            if (existingSpaces.Count >= 23)
                ParkinSpace023.Visible = true;
            if (existingSpaces.Count >= 24)
                ParkinSpace024.Visible = true;
            if (existingSpaces.Count >= 25)
                ParkinSpace025.Visible = true;
            if (existingSpaces.Count >= 26)
                ParkinSpace026.Visible = true;
            if (existingSpaces.Count >= 27)
                ParkinSpace027.Visible = true;
            if (existingSpaces.Count >= 28)
                ParkinSpace028.Visible = true;
            if (existingSpaces.Count >= 29)
                ParkinSpace029.Visible = true;
            if (existingSpaces.Count >= 31)
                ParkinSpace031.Visible = true;
            if (existingSpaces.Count >= 32)
                ParkinSpace032.Visible = true;
            if (existingSpaces.Count >= 33)
                ParkinSpace033.Visible = true;
            if (existingSpaces.Count >= 34)
                ParkinSpace034.Visible = true;
            if (existingSpaces.Count >= 35)
                ParkinSpace035.Visible = true;
            if (existingSpaces.Count >= 36)
                ParkinSpace036.Visible = true;
            if (existingSpaces.Count >= 37)
                ParkinSpace037.Visible = true;
            if (existingSpaces.Count >= 38)
                ParkinSpace038.Visible = true;
            if (existingSpaces.Count >= 39)
                ParkinSpace039.Visible = true;
            if (existingSpaces.Count >= 40)
                ParkinSpace040.Visible = true;
            if (existingSpaces.Count >= 41)
                ParkinSpace041.Visible = true;
            if (existingSpaces.Count >= 42)
                ParkinSpace042.Visible = true;
            if (existingSpaces.Count >= 43)
                ParkinSpace043.Visible = true;
            if (existingSpaces.Count >= 44)
                ParkinSpace044.Visible = true;
            if (existingSpaces.Count >= 45)
                ParkinSpace045.Visible = true;
            if (existingSpaces.Count >= 46)
                ParkinSpace046.Visible = true;
            if (existingSpaces.Count >= 47)
                ParkinSpace047.Visible = true;
            if (existingSpaces.Count >= 48)
                ParkinSpace048.Visible = true;
            if (existingSpaces.Count >= 49)
                ParkinSpace049.Visible = true;
            if (existingSpaces.Count >= 50)
                ParkinSpace050.Visible = true;
            if (existingSpaces.Count >= 51)
                ParkinSpace051.Visible = true;
            if (existingSpaces.Count >= 52)
                ParkinSpace052.Visible = true;
            if (existingSpaces.Count >= 53)
                ParkinSpace053.Visible = true;
            if (existingSpaces.Count >= 54)
                ParkinSpace054.Visible = true;
            if (existingSpaces.Count >= 55)
                ParkinSpace055.Visible = true;
            if (existingSpaces.Count >= 56)
                ParkinSpace056.Visible = true;
            if (existingSpaces.Count >= 57)
                ParkinSpace057.Visible = true;
            if (existingSpaces.Count >= 58)
                ParkinSpace058.Visible = true;
            if (existingSpaces.Count >= 59)
                ParkinSpace059.Visible = true;
            if (existingSpaces.Count >= 60)
                ParkinSpace060.Visible = true;
            if (existingSpaces.Count >= 61)
                ParkinSpace061.Visible = true;
            if (existingSpaces.Count >= 62)
                ParkinSpace062.Visible = true;
            if (existingSpaces.Count >= 63)
                ParkinSpace063.Visible = true;
            if (existingSpaces.Count >= 64)
                ParkinSpace064.Visible = true;
            if (existingSpaces.Count >= 65)
                ParkinSpace065.Visible = true;
            if (existingSpaces.Count >= 66)
                ParkinSpace066.Visible = true;
            if (existingSpaces.Count >= 67)
                ParkinSpace067.Visible = true;
            if (existingSpaces.Count >= 68)
                ParkinSpace068.Visible = true;
            if (existingSpaces.Count >= 69)
                ParkinSpace069.Visible = true;
            if (existingSpaces.Count >= 70)
                ParkinSpace070.Visible = true;
            if (existingSpaces.Count >= 71)
                ParkinSpace071.Visible = true;
            if (existingSpaces.Count >= 72)
                ParkinSpace072.Visible = true;
            if (existingSpaces.Count >= 73)
                ParkinSpace073.Visible = true;
            if (existingSpaces.Count >= 74)
                ParkinSpace074.Visible = true;
            if (existingSpaces.Count >= 75)
                ParkinSpace075.Visible = true;
            if (existingSpaces.Count >= 76)
                ParkinSpace076.Visible = true;
            if (existingSpaces.Count >= 77)
                ParkinSpace077.Visible = true;
            if (existingSpaces.Count >= 78)
                ParkinSpace078.Visible = true;
            if (existingSpaces.Count >= 79)
                ParkinSpace079.Visible = true;
            if (existingSpaces.Count >= 80)
                ParkinSpace080.Visible = true;
            if (existingSpaces.Count >= 81)
                ParkinSpace081.Visible = true;
            if (existingSpaces.Count >= 82)
                ParkinSpace082.Visible = true;
            if (existingSpaces.Count >= 83)
                ParkinSpace083.Visible = true;
            if (existingSpaces.Count >= 84)
                ParkinSpace084.Visible = true;
            if (existingSpaces.Count >= 85)
                ParkinSpace085.Visible = true;
            if (existingSpaces.Count >= 86)
                ParkinSpace086.Visible = true;
            if (existingSpaces.Count >= 87)
                ParkinSpace087.Visible = true;
            if (existingSpaces.Count >= 88)
                ParkinSpace088.Visible = true;
            if (existingSpaces.Count >= 89)
                ParkinSpace089.Visible = true;
            if (existingSpaces.Count >= 90)
                ParkinSpace090.Visible = true;
            if (existingSpaces.Count >= 91)
                ParkinSpace091.Visible = true;
            if (existingSpaces.Count >= 92)
                ParkinSpace092.Visible = true;
            if (existingSpaces.Count >= 93)
                ParkinSpace093.Visible = true;
            if (existingSpaces.Count >= 94)
                ParkinSpace094.Visible = true;
            if (existingSpaces.Count >= 95)
                ParkinSpace095.Visible = true;
            if (existingSpaces.Count >= 96)
                ParkinSpace096.Visible = true;
            if (existingSpaces.Count >= 97)
                ParkinSpace097.Visible = true;
            if (existingSpaces.Count >= 98)
                ParkinSpace098.Visible = true;
            if (existingSpaces.Count >= 99)
                ParkinSpace099.Visible = true;
            if (existingSpaces.Count >= 100)
                ParkinSpace100.Visible = true;
            if (existingSpaces.Count >= 101)
                ParkinSpace101.Visible = true;
            if (existingSpaces.Count >= 102)
                ParkinSpace102.Visible = true;
            if (existingSpaces.Count >= 103)
                ParkinSpace103.Visible = true;
            if (existingSpaces.Count >= 104)
                ParkinSpace104.Visible = true;
            if (existingSpaces.Count >= 105)
                ParkinSpace105.Visible = true;
            if (existingSpaces.Count >= 106)
                ParkinSpace106.Visible = true;
            if (existingSpaces.Count >= 107)
                ParkinSpace107.Visible = true;
            if (existingSpaces.Count >= 108)
                ParkinSpace108.Visible = true;
            if (existingSpaces.Count >= 109)
                ParkinSpace109.Visible = true;
            if (existingSpaces.Count >= 110)
                ParkinSpace110.Visible = true;
            if (existingSpaces.Count >= 111)
                ParkinSpace111.Visible = true;
            if (existingSpaces.Count >= 112)
                ParkinSpace112.Visible = true;
            if (existingSpaces.Count >= 113)
                ParkinSpace113.Visible = true;
            if (existingSpaces.Count >= 114)
                ParkinSpace114.Visible = true;
            if (existingSpaces.Count >= 115)
                ParkinSpace115.Visible = true;
            if (existingSpaces.Count >= 116)
                ParkinSpace116.Visible = true;
            if (existingSpaces.Count >= 117)
                ParkinSpace117.Visible = true;
            if (existingSpaces.Count >= 118)
                ParkinSpace118.Visible = true;
            if (existingSpaces.Count >= 119)
                ParkinSpace119.Visible = true;
            if (existingSpaces.Count >= 120)
                ParkinSpace120.Visible = true;
            
           
            
        }

        public void makeAllSpacesInvisible()
        {
            ParkinSpace001.Visible = false;
            ParkinSpace002.Visible = false;
            ParkinSpace003.Visible = false;
            ParkinSpace004.Visible = false;
            ParkinSpace005.Visible = false;
            ParkinSpace006.Visible = false;
            ParkinSpace007.Visible = false;
            ParkinSpace008.Visible = false;
            ParkinSpace009.Visible = false;
            ParkinSpace010.Visible = false;
            ParkinSpace011.Visible = false;
            ParkinSpace012.Visible = false;
            ParkinSpace013.Visible = false;
            ParkinSpace014.Visible = false;
            ParkinSpace015.Visible = false;
            ParkinSpace016.Visible = false;
            ParkinSpace017.Visible = false;
            ParkinSpace018.Visible = false;
            ParkinSpace019.Visible = false;
            ParkinSpace020.Visible = false;
            ParkinSpace021.Visible = false;
            ParkinSpace022.Visible = false;
            ParkinSpace023.Visible = false;
            ParkinSpace024.Visible = false;
            ParkinSpace025.Visible = false;
            ParkinSpace026.Visible = false;
            ParkinSpace027.Visible = false;
            ParkinSpace028.Visible = false;
            ParkinSpace029.Visible = false;
            ParkinSpace030.Visible = false;
            ParkinSpace031.Visible = false;
            ParkinSpace032.Visible = false;
            ParkinSpace033.Visible = false;
            ParkinSpace034.Visible = false;
            ParkinSpace035.Visible = false;
            ParkinSpace036.Visible = false;
            ParkinSpace037.Visible = false;
            ParkinSpace038.Visible = false;
            ParkinSpace039.Visible = false;
            ParkinSpace040.Visible = false;
            ParkinSpace041.Visible = false;
            ParkinSpace042.Visible = false;
            ParkinSpace043.Visible = false;
            ParkinSpace044.Visible = false;
            ParkinSpace045.Visible = false;
            ParkinSpace046.Visible = false;
            ParkinSpace047.Visible = false;
            ParkinSpace048.Visible = false;
            ParkinSpace049.Visible = false;
            ParkinSpace050.Visible = false;
            ParkinSpace051.Visible = false;
            ParkinSpace052.Visible = false;
            ParkinSpace053.Visible = false;
            ParkinSpace054.Visible = false;
            ParkinSpace055.Visible = false;
            ParkinSpace056.Visible = false;
            ParkinSpace057.Visible = false;
            ParkinSpace058.Visible = false;
            ParkinSpace059.Visible = false;
            ParkinSpace060.Visible = false;
            ParkinSpace061.Visible = false;
            ParkinSpace062.Visible = false;
            ParkinSpace063.Visible = false;
            ParkinSpace064.Visible = false;
            ParkinSpace065.Visible = false;
            ParkinSpace066.Visible = false;
            ParkinSpace067.Visible = false;
            ParkinSpace068.Visible = false;
            ParkinSpace069.Visible = false;
            ParkinSpace070.Visible = false;
            ParkinSpace071.Visible = false;
            ParkinSpace072.Visible = false;
            ParkinSpace073.Visible = false;
            ParkinSpace074.Visible = false;
            ParkinSpace075.Visible = false;
            ParkinSpace076.Visible = false;
            ParkinSpace077.Visible = false;
            ParkinSpace078.Visible = false;
            ParkinSpace079.Visible = false;
            ParkinSpace080.Visible = false;
            ParkinSpace081.Visible = false;
            ParkinSpace082.Visible = false;
            ParkinSpace083.Visible = false;
            ParkinSpace084.Visible = false;
            ParkinSpace085.Visible = false;
            ParkinSpace086.Visible = false;
            ParkinSpace087.Visible = false;
            ParkinSpace088.Visible = false;
            ParkinSpace089.Visible = false;
            ParkinSpace090.Visible = false;
            ParkinSpace091.Visible = false;
            ParkinSpace092.Visible = false;
            ParkinSpace093.Visible = false;
            ParkinSpace094.Visible = false;
            ParkinSpace095.Visible = false;
            ParkinSpace096.Visible = false;
            ParkinSpace097.Visible = false;
            ParkinSpace098.Visible = false;
            ParkinSpace099.Visible = false;
            ParkinSpace100.Visible = false;
            ParkinSpace101.Visible = false;
            ParkinSpace102.Visible = false;
            ParkinSpace103.Visible = false;
            ParkinSpace104.Visible = false;
            ParkinSpace105.Visible = false;
            ParkinSpace106.Visible = false;
            ParkinSpace107.Visible = false;
            ParkinSpace108.Visible = false;
            ParkinSpace109.Visible = false;
            ParkinSpace110.Visible = false;
            ParkinSpace111.Visible = false;
            ParkinSpace112.Visible = false;
            ParkinSpace113.Visible = false;
            ParkinSpace114.Visible = false;
            ParkinSpace115.Visible = false;
            ParkinSpace116.Visible = false;
            ParkinSpace117.Visible = false;
            ParkinSpace118.Visible = false;
            ParkinSpace119.Visible = false;
            ParkinSpace120.Visible = false;



        }


        protected void ParkinSpace001_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace002_Click(object sender, ImageClickEventArgs e)
        {
            
        }

        protected void ParkinSpace003_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace004_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace005_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace006_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace007_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace008_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace009_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace010_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace011_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace012_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace013_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace014_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace015_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace016_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace017_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace018_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace019_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace020_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace021_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace022_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace023_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace024_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace025_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace026_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace027_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace028_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace029_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace030_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace031_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace032_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace033_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace034_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace035_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace036_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace037_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace038_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace039_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace040_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace041_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace042_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace044_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace045_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace046_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace047_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace048_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace049_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace050_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace051_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace052_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace053_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace054_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace055_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace056_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace057_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace058_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace059_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace060_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace061_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace062_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace063_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace064_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace065_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace066_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace067_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace068_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace069_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace070_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace071_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace072_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace073_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace074_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace075_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace076_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace077_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace078_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace079_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace080_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace081_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace082_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace083_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace084_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace085_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace086_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace087_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace088_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace089_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace090_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace091_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace092_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace093_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace094_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace095_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace096_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace097_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace098_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace099_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace100_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace101_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace102_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace103_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace104_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace105_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace106_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace107_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace108_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace109_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace110_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace111_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace112_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace113_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace114_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace115_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace116_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace117_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace118_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace119_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ParkinSpace120_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Add_ParkingSpace_Click(object sender, EventArgs e)
        {
            LabelSpaceNumber.Visible = true;
            TextBoxSpaceIdentifier.Visible = true;
            ButtonInsertNewSpace.Visible = true;
            Add_ParkingSpace.Visible = false;

        }

        protected void ButtonInsertNewSpace_Click(object sender, EventArgs e)
        {
            if (TextBoxSpaceIdentifier.Text == "")
                LabelSpaceNumber.Text = "Debe ingresar un identificador o nombre!";
            else
            {
                if (isAnExistingName())
                {
                    LabelSpaceNumber.Text = "El nombre ya existe; no se puede usar!";
                }
                else
                {
                    insertSpaceInDB();
                }
            }

        }

            void insertSpaceInDB(){

                ParkingSpace newSpace = new ParkingSpace(TextBoxSpaceIdentifier.Text, 1);
                ParkingSpaceTransaction newSpaceTransaction = new ParkingSpaceTransaction();
                newSpaceTransaction.InsertNewParkingSpace(newSpace);

                ParkingSpaceTransaction transaction = new ParkingSpaceTransaction();
                List<string> existingSpaces = transaction.PrintExistingSpaces(1);
                printInScreen(existingSpaces);

            }

        bool isAnExistingName() {
            
            bool isExisting = false;
            ParkingSpaceTransaction transaction = new ParkingSpaceTransaction();
            List<string> lstExistingSpaces = transaction.PrintExistingSpaces(1);
            for (int i = 0; i < lstExistingSpaces.Count; i++)
            {
                if (lstExistingSpaces[i] == TextBoxSpaceIdentifier.Text)
                {
                    isExisting = true;
                    i = lstExistingSpaces.Count;
                }
            }

            return isExisting;
        }

        protected void Eliminate_ParkingSpace_Click(object sender, EventArgs e)
        {
            ParkingSpaceTransaction transaction = new ParkingSpaceTransaction();
            transaction.deleteLastSpaceinDB(1);
            showInScreenOnlyExistingSpaces();
        }

        protected void ButtonGoToReservation_Click(object sender, EventArgs e)
        {
            ButtonShowState.Visible = true;
            LabelFrom.Visible = true;
            LabelTo.Visible = true;
            LabelVehicle.Visible = true;
            LabelTime.Visible = true;
            DropDownListVehiclesOfOneUser.Visible = true;
            DropDownListCheckIn.Visible = true;
            DropDownListCheckOut.Visible = true;
            ButtonGoToReservation.Visible = false;
            ButtonFinishReservation.Visible = true;

        }



        public List<string> getSpacesReservedAtGivenPeriod(int checkInTime, int checkOutTime)
        {

            List<string> reservedSpacesPerPeriod = lstReservedSpacesInHour(checkInTime);
            List<string> reference;
            while (checkInTime < checkOutTime)
            {
                reference = lstReservedSpacesInHour(checkInTime);
                for (int i = 0; i == reference.Count - 1; i++)
                {
                    for (int j = 0; j < reservedSpacesPerPeriod.Count; j++)
                    {
                        if (reference[i] == reservedSpacesPerPeriod[j])
                        {
                            reference.RemoveAt(i);
                            j = reservedSpacesPerPeriod.Count;
                        }
                    }
                }

                for (int i = 0; i < reference.Count; i++)
                {
                    reservedSpacesPerPeriod.Add(reference[i]);
                }

            checkInTime++;
            }

            return reservedSpacesPerPeriod;
        }

        public List<string> lstReservedSpacesInHour(int idTimeForReservation)
        {

            DateTime date = DateTime.Today;
            ParkingSpaceTransaction transaction = new ParkingSpaceTransaction();
            List<string> reservedSpacesPerHour = transaction.GetAllReservedSpacesOnDayAndHour(1, date, idTimeForReservation);

            return reservedSpacesPerHour;
        }


        protected void ButtonShowState_Click(object sender, EventArgs e)
        {
            showInScreenOnlyExistingSpaces();
            int checkInTime = (int)(DropDownListCheckIn.SelectedIndex) + 1;
            int checkOutTime = (int)(DropDownListCheckOut.SelectedIndex) +1;
            showInScreenOnlyExistingSpaces();
            markAsOccupiedReservedSpaces(getSpacesReservedAtGivenPeriod(checkInTime, checkOutTime)); // Ésta es lista de los usados para este período dado

        }


        public void showInScreenOnlyExistingSpaces()
        {
            ParkingSpaceTransaction transaction = new ParkingSpaceTransaction();
            makeAllSpacesInvisible();
            List<string> existingSpaces = transaction.PrintExistingSpaces(1);
            printInScreen(existingSpaces);
        }


        public void markAsOccupiedReservedSpaces(List<string> lstReservedSpaces)
        {
            ParkingSpaceTransaction transaction = new ParkingSpaceTransaction();
            List<string> existingSpaces = transaction.PrintExistingSpaces(1);
            List<int> lstIndexes = lstIndexesOfReservedSpaces(existingSpaces, lstReservedSpaces);
            int spaceNumber = existingSpaces.Count;

            if (spaceNumber >= 1)
            {
                if (isAnOccupiedIndex(1, lstIndexes))
                    ParkinSpace001.ImageUrl = "ocuppiedParkingSpace.jpg";
                
            }

            if (spaceNumber >= 2)
            {
                if (isAnOccupiedIndex(2, lstIndexes))
                    ParkinSpace002.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 3)
            {
                if (isAnOccupiedIndex(3, lstIndexes))
                    ParkinSpace003.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 4)
            {
                if (isAnOccupiedIndex(4, lstIndexes))
                    ParkinSpace004.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 5)
            {
                if (isAnOccupiedIndex(5, lstIndexes))
                    ParkinSpace005.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 6)
            {
                if (isAnOccupiedIndex(6, lstIndexes))
                    ParkinSpace006.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 7)
            {
                if (isAnOccupiedIndex(7, lstIndexes))
                    ParkinSpace007.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 8)
            {
                if (isAnOccupiedIndex(8, lstIndexes))
                    ParkinSpace008.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 9)
            {
                if (isAnOccupiedIndex(9, lstIndexes))
                    ParkinSpace009.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 10)
            {
                if (isAnOccupiedIndex(10, lstIndexes))
                    ParkinSpace010.ImageUrl = "ocuppiedParkingSpace.jpg";

            }


            if (spaceNumber >= 11)
            {
                if (isAnOccupiedIndex(11, lstIndexes))
                    ParkinSpace011.ImageUrl = "ocuppiedParkingSpace.jpg";

            }


            if (spaceNumber >= 12)
            {
                if (isAnOccupiedIndex(12, lstIndexes))
                    ParkinSpace012.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 13)
            {
                if (isAnOccupiedIndex(13, lstIndexes))
                    ParkinSpace013.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 14)
            {
                if (isAnOccupiedIndex(14, lstIndexes))
                    ParkinSpace014.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 15)
            {
                if (isAnOccupiedIndex(15, lstIndexes))
                    ParkinSpace015.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 16)
            {
                if (isAnOccupiedIndex(16, lstIndexes))
                    ParkinSpace016.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 17)
            {
                if (isAnOccupiedIndex(17, lstIndexes))
                    ParkinSpace017.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 18)
            {
                if (isAnOccupiedIndex(18, lstIndexes))
                    ParkinSpace018.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 19)
            {
                if (isAnOccupiedIndex(19, lstIndexes))
                    ParkinSpace019.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 20)
            {
                if (isAnOccupiedIndex(20, lstIndexes))
                    ParkinSpace020.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 21)
            {
                if (isAnOccupiedIndex(21, lstIndexes))
                    ParkinSpace021.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 22)
            {
                if (isAnOccupiedIndex(22, lstIndexes))
                    ParkinSpace002.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 23)
            {
                if (isAnOccupiedIndex(23, lstIndexes))
                    ParkinSpace023.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 24)
            {
                if (isAnOccupiedIndex(24, lstIndexes))
                    ParkinSpace024.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 25)
            {
                if (isAnOccupiedIndex(25, lstIndexes))
                    ParkinSpace025.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 26)
            {
                if (isAnOccupiedIndex(26, lstIndexes))
                    ParkinSpace026.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 27)
            {
                if (isAnOccupiedIndex(27, lstIndexes))
                    ParkinSpace027.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 28)
            {
                if (isAnOccupiedIndex(28, lstIndexes))
                    ParkinSpace028.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 29)
            {
                if (isAnOccupiedIndex(29, lstIndexes))
                    ParkinSpace029.ImageUrl = "ocuppiedParkingSpace.jpg";

            }

            if (spaceNumber >= 30)
            {
                if (isAnOccupiedIndex(30, lstIndexes))
                    ParkinSpace030.ImageUrl = "ocuppiedParkingSpace.jpg";

            }





        }





        public bool isAnOccupiedIndex(int index, List<int> lstIndexes)
        {
            int i = 0;
            bool existsInList = false;
            while (existsInList == false && i < lstIndexes.Count)
            {
                if (index == lstIndexes[i])
                {
                    existsInList = true;
                }
                i++;
            }
            return existsInList;
        }


        public List<int> lstIndexesOfReservedSpaces(List<string> existingSpaces, List<string> lstReservedSpaces)
        {
            List<int> lstIndexes = new List<int>();
            for (int i = 0; i < lstReservedSpaces.Count; i++)
			{
                for (int j = 0; j < existingSpaces.Count; j++)
			    {
                    if (lstReservedSpaces[i] == existingSpaces[j])
                    {
                        lstIndexes.Add(j);
                    }
			    }
			}

            return lstIndexes;
        }


        void populateDDLListOfVehicles(User user)
        {
            //List<Vehicle> lstVehicles = new List<Vehicle>();
            ReservationTransaction transaction = new ReservationTransaction();
            List<Vehicle> lstVehicles = transaction.ReadVehiclesOfUser(user);
            DropDownListVehiclesOfOneUser.DataTextField = "numberPlate";
            DropDownListVehiclesOfOneUser.DataValueField = "id";
            DropDownListVehiclesOfOneUser.DataSource = lstVehicles;
            DropDownListVehiclesOfOneUser.DataBind();

        }

        protected void DropDownListVehiclesOfOneUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownListCheckIn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownListCheckOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        public SiCAP_GrupoCARARA.App_Domain.Reservation FillReservation(int idTimeForReservation)
        {
            int id = 0;
            UserData userData = new UserData();
            DateTime thisDay = DateTime.Today;
            string date = thisDay.ToString("dd/MM/yyyy");
            User userInSession = userData.getUserInSession((string)Session["user"]);
            int idUser = userInSession.Id;
            int idParkingSpace = 3;  //   Aquí hay que meter lo que viene de los botones...!!!!!!!!!!!!!!!!!!!!!!!!!!
            int idVehicle = int.Parse(DropDownListVehiclesOfOneUser.SelectedItem.Value);
            bool hasBeenCanceled = false;

            SiCAP_GrupoCARARA.App_Domain.Reservation myReservation = new SiCAP_GrupoCARARA.App_Domain.Reservation(id, thisDay, idTimeForReservation, idUser, idParkingSpace, idVehicle, hasBeenCanceled);


            return myReservation;
        }

        public void InsertReservationInGivenPeriod()
        {
            ReservationTransaction transaction = new ReservationTransaction();
            int checkInTime = int.Parse(DropDownListCheckIn.SelectedItem.Value);
            int checkOutTime = int.Parse(DropDownListCheckOut.SelectedItem.Value);

            while (checkInTime <= checkOutTime)
            {
                SiCAP_GrupoCARARA.App_Domain.Reservation myReservation = FillReservation(checkInTime);
                transaction.InsertReservation(myReservation);
                checkInTime++;
            }

        }

        protected void ButtonFinishReservation_Click(object sender, EventArgs e)
        {
            ButtonInsertReservation.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            InsertReservationInGivenPeriod();
        }

        
    }
}