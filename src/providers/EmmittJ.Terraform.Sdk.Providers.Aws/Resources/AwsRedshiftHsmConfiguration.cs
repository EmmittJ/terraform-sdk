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
        SetOutput("arn");
        SetOutput("description");
        SetOutput("hsm_configuration_identifier");
        SetOutput("hsm_ip_address");
        SetOutput("hsm_partition_name");
        SetOutput("hsm_partition_password");
        SetOutput("hsm_server_public_certificate");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The hsm_configuration_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmConfigurationIdentifier is required")]
    public required TerraformProperty<string> HsmConfigurationIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hsm_configuration_identifier");
        set => SetProperty("hsm_configuration_identifier", value);
    }

    /// <summary>
    /// The hsm_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmIpAddress is required")]
    public required TerraformProperty<string> HsmIpAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hsm_ip_address");
        set => SetProperty("hsm_ip_address", value);
    }

    /// <summary>
    /// The hsm_partition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmPartitionName is required")]
    public required TerraformProperty<string> HsmPartitionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hsm_partition_name");
        set => SetProperty("hsm_partition_name", value);
    }

    /// <summary>
    /// The hsm_partition_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmPartitionPassword is required")]
    public required TerraformProperty<string> HsmPartitionPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hsm_partition_password");
        set => SetProperty("hsm_partition_password", value);
    }

    /// <summary>
    /// The hsm_server_public_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmServerPublicCertificate is required")]
    public required TerraformProperty<string> HsmServerPublicCertificate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hsm_server_public_certificate");
        set => SetProperty("hsm_server_public_certificate", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
