using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_default_patch_baseline resource.
/// </summary>
public class AwsSsmDefaultPatchBaseline : TerraformResource
{
    public AwsSsmDefaultPatchBaseline(string name) : base("aws_ssm_default_patch_baseline", name)
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
    /// The operating_system attribute.
    /// </summary>
    public string? OperatingSystem
    {
        get => GetProperty<TerraformLiteralProperty<string>>("operating_system")?.Value;
        set => this.WithProperty("operating_system", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
