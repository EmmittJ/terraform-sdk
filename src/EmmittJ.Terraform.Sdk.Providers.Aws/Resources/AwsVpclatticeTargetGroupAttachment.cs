using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpclattice_target_group_attachment resource.
/// </summary>
public class AwsVpclatticeTargetGroupAttachment : TerraformResource
{
    public AwsVpclatticeTargetGroupAttachment(string name) : base("aws_vpclattice_target_group_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_group_identifier attribute.
    /// </summary>
    public string? TargetGroupIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_group_identifier")?.Value;
        set => this.WithProperty("target_group_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
