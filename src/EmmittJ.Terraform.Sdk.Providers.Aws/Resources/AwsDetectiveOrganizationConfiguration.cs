using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_detective_organization_configuration resource.
/// </summary>
public class AwsDetectiveOrganizationConfiguration : TerraformResource
{
    public AwsDetectiveOrganizationConfiguration(string name) : base("aws_detective_organization_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    public bool? AutoEnable
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_enable")?.Value;
        set => this.WithProperty("auto_enable", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The graph_arn attribute.
    /// </summary>
    public string? GraphArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("graph_arn")?.Value;
        set => this.WithProperty("graph_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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

}
