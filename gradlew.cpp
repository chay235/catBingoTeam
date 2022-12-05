var gradlewsPath = Path.Combine(new DirectoryInfo(Application.dataPath).Parent.FullName, GradleDir);
            var gradleWrapperPath = Path.Combine(gradlewsPath, "gradle");
 
            foreach (var directory in Directory.GetDirectories(gradleWrapperPath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(directory.Replace(gradlewsPath, projectPath));
            }
            foreach (var file in Directory.GetFiles(gradleWrapperPath, "*", SearchOption.AllDirectories))
            {
                File.Copy(file, file.Replace(gradlewsPath, projectPath), true);
            }
 
            File.Copy(Path.Combine(gradlewsPath, GradlewName), Path.Combine(projectPath, GradlewName), true);