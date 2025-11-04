using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssm_patch_baselines.
/// </summary>
public class AwsSsmPatchBaselinesDataSource : TerraformDataSource
{
    public AwsSsmPatchBaselinesDataSource(string name) : base("aws_ssm_patch_baselines", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("baseline_identities");
    }

    /// <summary>
    /// The default_baselines attribute.
    /// </summary>
    public bool? DefaultBaselines
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("default_baselines")?.Value;
        set => this.WithProperty("default_baselines", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The baseline_identities attribute.
    /// </summary>
    public TerraformExpression BaselineIdentities => this["baseline_identities"];

}
