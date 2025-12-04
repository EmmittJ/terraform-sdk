using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_hsm_configuration Terraform resource.
/// Manages a aws_redshift_hsm_configuration resource.
/// </summary>
public partial class AwsRedshiftHsmConfiguration(string name) : TerraformResource("aws_redshift_hsm_configuration", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The hsm_configuration_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmConfigurationIdentifier is required")]
    public required TerraformValue<string> HsmConfigurationIdentifier
    {
        get => GetArgument<TerraformValue<string>>("hsm_configuration_identifier");
        set => SetArgument("hsm_configuration_identifier", value);
    }

    /// <summary>
    /// The hsm_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmIpAddress is required")]
    public required TerraformValue<string> HsmIpAddress
    {
        get => GetArgument<TerraformValue<string>>("hsm_ip_address");
        set => SetArgument("hsm_ip_address", value);
    }

    /// <summary>
    /// The hsm_partition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmPartitionName is required")]
    public required TerraformValue<string> HsmPartitionName
    {
        get => GetArgument<TerraformValue<string>>("hsm_partition_name");
        set => SetArgument("hsm_partition_name", value);
    }

    /// <summary>
    /// The hsm_partition_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmPartitionPassword is required")]
    public required TerraformValue<string> HsmPartitionPassword
    {
        get => GetArgument<TerraformValue<string>>("hsm_partition_password");
        set => SetArgument("hsm_partition_password", value);
    }

    /// <summary>
    /// The hsm_server_public_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmServerPublicCertificate is required")]
    public required TerraformValue<string> HsmServerPublicCertificate
    {
        get => GetArgument<TerraformValue<string>>("hsm_server_public_certificate");
        set => SetArgument("hsm_server_public_certificate", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
