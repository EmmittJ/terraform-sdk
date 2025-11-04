using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_hsm_configuration resource.
/// </summary>
public class AwsRedshiftHsmConfiguration : TerraformResource
{
    public AwsRedshiftHsmConfiguration(string name) : base("aws_redshift_hsm_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hsm_configuration_identifier attribute.
    /// </summary>
    public string? HsmConfigurationIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hsm_configuration_identifier")?.Value;
        set => this.WithProperty("hsm_configuration_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hsm_ip_address attribute.
    /// </summary>
    public string? HsmIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hsm_ip_address")?.Value;
        set => this.WithProperty("hsm_ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hsm_partition_name attribute.
    /// </summary>
    public string? HsmPartitionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hsm_partition_name")?.Value;
        set => this.WithProperty("hsm_partition_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hsm_partition_password attribute.
    /// </summary>
    public string? HsmPartitionPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hsm_partition_password")?.Value;
        set => this.WithProperty("hsm_partition_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hsm_server_public_certificate attribute.
    /// </summary>
    public string? HsmServerPublicCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hsm_server_public_certificate")?.Value;
        set => this.WithProperty("hsm_server_public_certificate", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
