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
    public TerraformLiteralProperty<string>? BaselineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("baseline_id");
        set => this.WithProperty("baseline_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The patch_group attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PatchGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("patch_group");
        set => this.WithProperty("patch_group", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
