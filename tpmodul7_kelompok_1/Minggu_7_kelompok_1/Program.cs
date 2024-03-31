using System;
using System.Reflection;
using System.Text.Json;
using System.IO;
using tpmodul7_kelompok_1;
using System.Text.Json.Serialization;

class program
{
    static void Main(string[] args)
    {
        // read json file

        string json = File.ReadAllText("D:\\KPL\\TP\\tpmod7_1302220141\\tpmodul7_kelompok_1\\tpmodul7_kelompok_1\\tp7_1_1302220141.json");

        var options = new JsonSerializerOptions
        {
            IncludeFields = true
        };
        DataMahasiswa_1302220141 data = JsonSerializer.Deserialize<DataMahasiswa_1302220141>(json, options);
        data.details();
        //File.WriteAllText("C:\\Users\\USER\\Documents\\Kuliah\\Semester 4\\KPL\\Praktikum\\TPMOD07\\TPMOD07\\TPMOD07\\tp7_1_1302220065.json",);

        string Default_Course = File.ReadAllText("D:\\KPL\\TP\\tpmod7_1302220141\\tpmodul7_kelompok_1\\tpmodul7_kelompok_1\\tp7_2_1302220141.json");
        KuliahMahasiswa_1302220141 data2 = JsonSerializer.Deserialize<KuliahMahasiswa_1302220141>(Default_Course, options);
        data2.PrintCourses();

        string MyCourse = File.ReadAllText("D:\\KPL\\TP\\tpmod7_1302220141\\tpmodul7_kelompok_1\\tpmodul7_kelompok_1\\tp7_2_1302220141.json");
        KuliahMahasiswa_1302220141 data3 = JsonSerializer.Deserialize<KuliahMahasiswa_1302220141>(MyCourse, options);
        data3.PrintCourses();
        data2.changeToMyCourse(data3);

        string new_Course = JsonSerializer.Serialize(data3, options);
        File.WriteAllText("D:\\KPL\\TP\\tpmod7_1302220141\\tpmodul7_kelompok_1\\tpmodul7_kelompok_1\\tp7_2_1302220141.json", new_Course);




    }
}
