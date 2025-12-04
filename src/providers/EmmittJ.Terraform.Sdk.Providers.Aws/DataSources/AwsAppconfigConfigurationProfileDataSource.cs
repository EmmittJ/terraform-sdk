using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_appconfig_configuration_profile Terraform data source.
/// Retrieves information about a aws_appconfig_configuration_profile.
/// </summary>
public partial class AwsAppconfigConfigurationProfileDataSource(string name) : TerraformDataSource("aws_appconfig_configuration_profile", name)
{
    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The configuration_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationProfileId is required")]
    public required TerraformValue<string> ConfigurationProfileId
    {
        get => GetRequiredArgument<TerraformValue<string>>("configuration_profile_id");
        set => SetArgument("configuration_profile_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyIdentifier
        => AsReference("kms_key_identifier");

    /// <summary>
    /// The location_uri attribute.
    /// </summary>
    public TerraformValue<string> LocationUri
        => AsReference("location_uri");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The retrieval_role_arn attribute.
    /// </summary>
    public TerraformValue<string> RetrievalRoleArn
        => AsReference("retrieval_role_arn");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// The validator attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Validator
        => AsReference("validator");

}
