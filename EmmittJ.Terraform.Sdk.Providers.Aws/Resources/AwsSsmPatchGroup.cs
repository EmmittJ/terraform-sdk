using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_patch_group resource.
/// </summary>
public class AwsSsmPatchGroup : TerraformResource
{
    public AwsSsmPatchGroup(string name) : base("aws_ssm_patch_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The baseline_id attribute.
    /// </summary>
    public string? BaselineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("baseline_id")?.Value;
        set => this.WithProperty("baseline_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The patch_group attribute.
    /// </summary>
    public string? PatchGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("patch_group")?.Value;
        set => this.WithProperty("patch_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
