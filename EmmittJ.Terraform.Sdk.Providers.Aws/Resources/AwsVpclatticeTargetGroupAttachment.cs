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
    /// The target_group_identifier attribute.
    /// </summary>
    public string? TargetGroupIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_group_identifier")?.Value;
        set => this.WithProperty("target_group_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
