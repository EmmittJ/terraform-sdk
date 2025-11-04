using System.Diagnostics;
using System.Text.Json;
using EmmittJ.Terraform.Sdk.CodeGen.Models;
using EmmittJ.Terraform.Sdk.CodeGen.Parsers;
using EmmittJ.Terraform.Sdk.CodeGen.Schema;
using EmmittJ.Terraform.Sdk.CodeGen.Templates;

namespace EmmittJ.Terraform.Sdk.CodeGen;

class Program
{
    static async Task<int> Main(string[] args)
    {
        Console.WriteLine("Terraform SDK Code Generator");
        Console.WriteLine("============================\n");

        // Determine paths
        var workspaceRoot = FindWorkspaceRoot();
        if (workspaceRoot == null)
        {
            Console.WriteLine("ERROR: Could not find workspace root (looking for AspireTerraform.sln)");
            return 1;
        }

        var templatePath = Path.Combine(AppContext.BaseDirectory, "Templates", "Files");

        Console.WriteLine($"Workspace root: {workspaceRoot}");
        Console.WriteLine($"Template path: {templatePath}\n");

        // Define providers to generate
        var providers = new[]
        {
            new ProviderConfig
            {
                Name = "aws",
                Namespace = "EmmittJ.Terraform.Sdk.Providers.Aws",
                FolderPath = "", // Will be created dynamically
                Version = "~> 5.0"
            },
            // Add more providers as needed
            // new ProviderConfig { Name = "azurerm", Namespace = "EmmittJ.Terraform.Sdk.Providers.Azure", Version = "~> 3.0" },
            // new ProviderConfig { Name = "google", Namespace = "EmmittJ.Terraform.Sdk.Providers.Google", Version = "~> 5.0" },
        };

        foreach (var provider in providers)
        {
            Console.WriteLine($"\n--- Processing Provider: {provider.Name} ---");

            try
            {
                await ProcessProvider(provider, templatePath, workspaceRoot);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR processing {provider.Name}: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                return 1;
            }
        }

        Console.WriteLine("\n✅ Code generation completed successfully!");
        return 0;
    }

    static async Task ProcessProvider(ProviderConfig config, string templatePath, string workspaceRoot)
    {
        // Step 1: Create working Terraform directory
        var workingDir = Path.Combine(Directory.GetCurrentDirectory(), ".terraform-codegen", config.Name);
        Directory.CreateDirectory(workingDir);

        Console.WriteLine($"Using working directory: {workingDir}");

        // Generate Terraform configuration
        var terraformConfig = GenerateTerraformConfig(config);
        var configPath = Path.Combine(workingDir, "main.tf");
        await File.WriteAllTextAsync(configPath, terraformConfig);
        Console.WriteLine($"Generated Terraform config");

        // Step 2: Generate schema
        var schemaPath = Path.Combine(workingDir, "schema.json");
        Console.WriteLine($"Generating schema from Terraform...");
        await GenerateSchema(workingDir, schemaPath);

        // Step 3: Parse the schema
        Console.WriteLine("Parsing schema...");
        var schemaJson = await File.ReadAllTextAsync(schemaPath);
        var parser = new SchemaParser();
        var schemaRoot = parser.ParseSchema(schemaJson);

        // Find the provider schema (handle different key formats)
        var providerSchema = schemaRoot.ProviderSchemas.Values.FirstOrDefault();
        if (providerSchema == null)
        {
            throw new InvalidOperationException($"No provider schema found in {schemaPath}");
        }

        Console.WriteLine($"Found {providerSchema.ResourceSchemas.Count} resources");
        Console.WriteLine($"Found {providerSchema.DataSourceSchemas.Count} data sources");

        // Step 4: Parse resources and data sources
        var resources = parser.ParseResources(providerSchema, config.Name);
        var dataSources = parser.ParseDataSources(providerSchema, config.Name);

        // Step 5: Generate code
        var outputFolder = Path.Combine(workspaceRoot, $"EmmittJ.Terraform.Sdk.Providers.{ToPascalCase(config.Name)}");
        if (Directory.Exists(outputFolder))
        {
            Directory.Delete(outputFolder, recursive: true);
        }
        Directory.CreateDirectory(outputFolder);

        var resourcesFolder = Path.Combine(outputFolder, "Resources");
        var dataSourcesFolder = Path.Combine(outputFolder, "DataSources");
        Directory.CreateDirectory(resourcesFolder);
        Directory.CreateDirectory(dataSourcesFolder);

        Console.WriteLine($"\nGenerating resources to: {resourcesFolder}");
        var resourceTemplate = new ResourceTemplate(templatePath);
        foreach (var resource in resources.Take(10)) // Start with first 10 for testing
        {
            var code = resourceTemplate.Generate(resource, config.Namespace);
            var filePath = Path.Combine(resourcesFolder, $"{resource.ClassName}.cs");
            await File.WriteAllTextAsync(filePath, code);
            Console.WriteLine($"  ✓ {resource.ClassName}");
        }

        Console.WriteLine($"\nGenerating data sources to: {dataSourcesFolder}");
        var dataSourceTemplate = new DataSourceTemplate(templatePath);
        foreach (var dataSource in dataSources.Take(10)) // Start with first 10 for testing
        {
            var code = dataSourceTemplate.Generate(dataSource, config.Namespace);
            var filePath = Path.Combine(dataSourcesFolder, $"{dataSource.ClassName}.cs");
            await File.WriteAllTextAsync(filePath, code);
            Console.WriteLine($"  ✓ {dataSource.ClassName}");
        }

        Console.WriteLine($"\n✅ Generated {Math.Min(10, resources.Count)} resources and {Math.Min(10, dataSources.Count)} data sources for {config.Name}");
    }

    static string GenerateTerraformConfig(ProviderConfig config)
    {
        return config.Name switch
        {
            "aws" => $@"terraform {{
  required_providers {{
    aws = {{
      source  = ""hashicorp/aws""
      version = ""{config.Version}""
    }}
  }}
}}

provider ""aws"" {{
  region = ""us-east-1""
  
  # Skip credentials for schema generation only
  skip_credentials_validation = true
  skip_requesting_account_id  = true
  skip_metadata_api_check     = true
}}
",
            "azurerm" => $@"terraform {{
  required_providers {{
    azurerm = {{
      source  = ""hashicorp/azurerm""
      version = ""{config.Version}""
    }}
  }}
}}

provider ""azurerm"" {{
  features {{}}
}}
",
            "google" => $@"terraform {{
  required_providers {{
    google = {{
      source  = ""hashicorp/google""
      version = ""{config.Version}""
    }}
  }}
}}

provider ""google"" {{
  project = ""schema-generation-project""
  region  = ""us-central1""
}}
",
            _ => throw new NotSupportedException($"Provider {config.Name} is not supported")
        };
    }

    static async Task GenerateSchema(string providerFolder, string outputPath)
    {
        // Run terraform init
        Console.WriteLine("  Running: terraform init");
        await RunCommand("terraform", "init", providerFolder);

        // Run terraform providers schema
        Console.WriteLine("  Running: terraform providers schema -json");
        var schemaJson = await RunCommandWithOutput("terraform", "providers schema -json", providerFolder);

        await File.WriteAllTextAsync(outputPath, schemaJson);
        Console.WriteLine($"  ✓ Schema saved to: {outputPath}");
    }

    static async Task RunCommand(string command, string arguments, string workingDirectory)
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = command,
            Arguments = arguments,
            WorkingDirectory = workingDirectory,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using var process = Process.Start(startInfo);
        if (process == null)
            throw new InvalidOperationException($"Failed to start {command}");

        await process.WaitForExitAsync();

        if (process.ExitCode != 0)
        {
            var error = await process.StandardError.ReadToEndAsync();
            throw new InvalidOperationException($"{command} failed with exit code {process.ExitCode}: {error}");
        }
    }

    static async Task<string> RunCommandWithOutput(string command, string arguments, string workingDirectory)
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = command,
            Arguments = arguments,
            WorkingDirectory = workingDirectory,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using var process = Process.Start(startInfo);
        if (process == null)
            throw new InvalidOperationException($"Failed to start {command}");

        var output = await process.StandardOutput.ReadToEndAsync();
        await process.WaitForExitAsync();

        if (process.ExitCode != 0)
        {
            var error = await process.StandardError.ReadToEndAsync();
            throw new InvalidOperationException($"{command} failed with exit code {process.ExitCode}: {error}");
        }

        return output;
    }

    static string? FindWorkspaceRoot()
    {
        var current = Directory.GetCurrentDirectory();

        while (current != null)
        {
            if (File.Exists(Path.Combine(current, "AspireTerraform.sln")))
                return current;

            current = Directory.GetParent(current)?.FullName;
        }

        return null;
    }

    static string ToPascalCase(string name)
    {
        return string.Join("", name.Split('_', '-')
            .Select(part => char.ToUpper(part[0]) + part.Substring(1).ToLower()));
    }
}
