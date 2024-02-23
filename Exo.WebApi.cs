<Project Sdk="Microsoft.NET.Sdk.Web">
  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <Nullable>disable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.2.3"/>
    <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.0"/>
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="6.0.0"/>
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.0"/>
    <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="6.0.0"/>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.1"/>
  </ItemGroup>
</Project>
