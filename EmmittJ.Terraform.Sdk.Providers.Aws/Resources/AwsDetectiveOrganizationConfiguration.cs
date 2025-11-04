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

}
