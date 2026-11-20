// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Aspire.Hosting.Terraform.Modules;

namespace EmmittJ.Aspire.Hosting.Terraform.Modules.Tests;

public class TerraformModuleTests
{
    [Fact]
    public void AddTerraformModule_ResolvesPathRelativeToAppHost()
    {
        var builder = DistributedApplication.CreateBuilder();

        var module = builder.AddTerraformModule("network", "./infra/network");

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
    public async Task GetOutput_InRunMode_ExplainsHowToSupplyValue()
    {
        var builder = DistributedApplication.CreateBuilder();
        var module = builder.AddTerraformModule("network", "./infra/network");

        var ex = await Assert.ThrowsAsync<DistributedApplicationException>(
            async () => await module.GetOutput("network_id").GetValueAsync());

        Assert.Contains("RunWithOutput", ex.Message);
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

    [Fact]
    public async Task GetOutput_InRunMode_UsesRunWithOutputValue()
    {
        var builder = DistributedApplication.CreateBuilder();
        var module = builder.AddTerraformModule("app", "./infra/app")
            .RunWithOutput("app_id", "local-app")
            .RunWithOutput("url", ReferenceExpression.Create($"http://{"host"}:80"));

        Assert.Equal("local-app", await module.GetOutput("app_id").GetValueAsync());
        Assert.Equal("http://host:80", await module.GetOutput("url").GetValueAsync());
    }

    [Fact]
    public async Task GetOutput_InPublishMode_IgnoresRunWithOutput()
    {
        var builder = DistributedApplication.CreateBuilder(["--operation", "publish", "--output-path", Path.GetTempPath()]);
        var module = builder.AddTerraformModule("app", "./infra/app").RunWithOutput("app_id", "local-app");

        using var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(100));

        await Assert.ThrowsAnyAsync<OperationCanceledException>(
            async () => await module.GetOutput("app_id").GetValueAsync(cts.Token));
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
            File.WriteAllText(Path.Combine(dir, "main.tf"), "output \"greeting\" { value = \"hello\" }");
            RunTerraform(dir, "init -input=false");
            RunTerraform(dir, "apply -auto-approve -input=false");

            var builder = DistributedApplication.CreateBuilder();
            var module = builder.AddTerraformModule("m", dir).RunAsExisting();

            Assert.Equal("hello", await module.GetOutput("greeting").GetValueAsync());
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
