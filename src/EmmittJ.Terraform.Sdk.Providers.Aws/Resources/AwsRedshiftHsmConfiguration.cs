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
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The hsm_configuration_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HsmConfigurationIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hsm_configuration_identifier");
        set => this.WithProperty("hsm_configuration_identifier", value);
    }

    /// <summary>
    /// The hsm_ip_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HsmIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hsm_ip_address");
        set => this.WithProperty("hsm_ip_address", value);
    }

    /// <summary>
    /// The hsm_partition_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HsmPartitionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hsm_partition_name");
        set => this.WithProperty("hsm_partition_name", value);
    }

    /// <summary>
    /// The hsm_partition_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HsmPartitionPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hsm_partition_password");
        set => this.WithProperty("hsm_partition_password", value);
    }

    /// <summary>
    /// The hsm_server_public_certificate attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HsmServerPublicCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hsm_server_public_certificate");
        set => this.WithProperty("hsm_server_public_certificate", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
