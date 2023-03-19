string path = "D:/Учеба/Знакомство с языками программирования/Lection_1/Example002_HelloUser";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for(int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}