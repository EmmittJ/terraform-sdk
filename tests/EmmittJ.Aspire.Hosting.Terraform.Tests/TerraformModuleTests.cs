// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Aspire.Hosting.Terraform;

namespace EmmittJ.Aspire.Hosting.Terraform.Tests;

public class TerraformModuleTests
{
    [Fact]
    public void AddTerraformConfiguration_ResolvesPathRelativeToAppHost()
    {
        var builder = DistributedApplication.CreateBuilder();

        var module = builder.AddTerraformConfiguration("network", "./infra/network");

        Assert.Equal(Path.GetFullPath("./infra/network", builder.AppHostDirectory), module.Resource.ModuleDirectory);
    }

    [Fact]
    public void GetOutput_UsesExactTerraformOutputName()
    {
        var builder = DistributedApplication.CreateBuilder();
        var module = builder.AddTerraformModule("network", "./infra/network");

        var output = module.GetOutput("network_id");

        Assert.Equal("network_id", output.Name);
        Assert.Equal("{network.outputs.network_id}", output.ValueExpression);
    }

    [Fact]
    public async Task GetOutput_InRunMode_UsesParameter()
    {
        var builder = DistributedApplication.CreateBuilder(new DistributedApplicationOptions { Args = [] });
        builder.Configuration["Parameters:network-network-id"] = "net-1";
        var module = builder.AddTerraformModule("network", "./infra/network");

        var output = module.GetOutput("network_id");

        Assert.Contains(builder.Resources, r => r is ParameterResource { Name: "network-network-id" });
        Assert.Equal("net-1", await output.GetValueAsync());
    }

    [Fact]
    public void RunAsExisting_AfterGetOutput_Throws()
    {
        var builder = DistributedApplication.CreateBuilder();
        var module = builder.AddTerraformConfiguration("network", "./infra/network");
        module.GetOutput("network_id");

        Assert.Throws<DistributedApplicationException>(() => module.RunAsExisting());
    }

    [Fact]
    public void GetOutput_InRunMode_WithRunAsExisting_AddsNoParameter()
    {
        var builder = DistributedApplication.CreateBuilder();
        builder.AddTerraformConfiguration("network", "./infra/network").RunAsExisting().GetOutput("network_id");

        Assert.DoesNotContain(builder.Resources, r => r is ParameterResource);
    }

    [Fact]
    public void WithVariable_RecordsValuesUnderTerraformVariableName()
    {
        var builder = DistributedApplication.CreateBuilder();
        var network = builder.AddTerraformModule("network", "./infra/network");
        var app = builder.AddTerraformModule("app", "./infra/app")
            .WithVariable("network_id", network.GetOutput("network_id"))
            .WithVariable("callback_url", "https://example.com");

        Assert.Equal(["callback_url", "network_id"], app.Resource.Variables.Keys.Order());
    }

    [Fact]
    public void AddTerraformModule_InRunMode_IsNotAddedToModel()
    {
        var builder = DistributedApplication.CreateBuilder();

        builder.AddTerraformModule("network", "./infra/network");

        Assert.Empty(builder.Resources.OfType<TerraformModuleResource>());
    }

    [Fact]
    public void AddTerraformModule_InPublishMode_IsAddedToModelWithPipelineSteps()
    {
        var builder = DistributedApplication.CreateBuilder(["--operation", "publish", "--output-path", Path.GetTempPath()]);

        var module = builder.AddTerraformModule("network", "./infra/network");

        Assert.Contains(module.Resource, builder.Resources);
        Assert.True(module.Resource.Annotations.Count > 0);
    }

    [Theory]
    [InlineData("module")]
    [InlineData("configuration")]
    [InlineData("template")]
    [InlineData("templateString")]
    public void PublishAsTerraform_InPublishMode_AddsTerraformDeploymentTarget(string kind)
    {
        var builder = DistributedApplication.CreateBuilder(["--operation", "publish", "--output-path", Path.GetTempPath()]);
        var api = builder.AddContainer("api", "img").WithHttpEndpoint(name: "http");

        _ = kind switch
        {
            "module" => api.PublishAsTerraformModule("./modules/api", m => m.MapEndpoint("http", EndpointProperty.Url, "url")),
            "configuration" => api.PublishAsTerraformConfiguration("./infra/api", m => m.MapEndpoint("http", EndpointProperty.Url, "url")),
            "template" => api.PublishAsTerraformTemplate("./api.tf", m => m.MapEndpoint("http", EndpointProperty.Url, "url")),
            _ => api.PublishAsTerraformTemplateString("variable \"x\" {}", m => m.MapEndpoint("http", EndpointProperty.Url, "url"))
        };

        var target = Assert.IsType<TerraformModuleResource>(api.Resource.GetDeploymentTargetAnnotation()!.DeploymentTarget);
        Assert.Equal(kind == "configuration", target.ModuleDirectory is not null);
    }

    [Fact]
    public void PublishAsTerraform_InRunMode_DoesNothing()
    {
        var builder = DistributedApplication.CreateBuilder();
        var api = builder.AddContainer("api", "img");

        api.PublishAsTerraformModule("./modules/api");
        api.PublishAsTerraformTemplateString("variable \"x\" {}");

        Assert.Null(api.Resource.GetDeploymentTargetAnnotation());
        Assert.DoesNotContain(builder.Resources, r => r is TerraformModuleResource);
    }

    [Fact]
    public async Task GetOutput_InRunMode_RunAsExistingReadsApplyState()
    {
        if (!TerraformAvailable())
        {
            return;
        }

        var dir = Directory.CreateTempSubdirectory().FullName;
        try
        {
            File.WriteAllText(Path.Combine(dir, "main.tf"), "output \"greeting\" { value = \"hello\" }\noutput \"flag\" { value = true }\noutput \"id\" { value = \"lower\" }\noutput \"ID\" { value = \"upper\" }");
            RunTerraform(dir, "init -input=false");
            RunTerraform(dir, "apply -auto-approve -input=false");

            var builder = DistributedApplication.CreateBuilder();
            var module = builder.AddTerraformConfiguration("m", dir).RunAsExisting();

            Assert.Equal("hello", await module.GetOutput("greeting").GetValueAsync());
            Assert.Equal("true", await module.GetOutput("flag").GetValueAsync());
            Assert.Equal("lower", await module.GetOutput("id").GetValueAsync());
            Assert.Equal("upper", await module.GetOutput("ID").GetValueAsync());
            await Assert.ThrowsAsync<DistributedApplicationException>(async () => await module.GetOutput("nope").GetValueAsync());
        }
        finally
        {
            Directory.Delete(dir, recursive: true);
        }
    }

    private static bool TerraformAvailable()
    {
        try
        {
            RunTerraform(Environment.CurrentDirectory, "version");
            return true;
        }
        catch (System.ComponentModel.Win32Exception)
        {
            return false;
        }
    }

    private static void RunTerraform(string dir, string args)
    {
        using var p = System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("terraform", args)
        {
            WorkingDirectory = dir,
            RedirectStandardOutput = true,
            RedirectStandardError = true
        })!;
        p.StandardOutput.ReadToEnd();
        p.WaitForExit();
        Assert.Equal(0, p.ExitCode);
    }
}
