build: Program.cs AssemblyInfo.cs
	rm -f bin/Debug/netcoreapp1.1/publish/*.zip && \
		dotnet publish && \
		cd bin/Debug/netcoreapp1.1/publish && \
		zip cslambda.zip * && \
		cd -
