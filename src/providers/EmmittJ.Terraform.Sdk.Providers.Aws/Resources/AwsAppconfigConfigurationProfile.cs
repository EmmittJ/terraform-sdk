using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for validator in AwsAppconfigConfigurationProfile.
/// Nesting mode: set
/// </summary>
public class AwsAppconfigConfigurationProfileValidatorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validator";

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformValue<string>? Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_appconfig_configuration_profile Terraform resource.
/// Manages a aws_appconfig_configuration_profile resource.
/// </summary>
public partial class AwsAppconfigConfigurationProfile(string name) : TerraformResource("aws_appconfig_configuration_profile", name)
{
    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => new TerraformReference<string>(this, "application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyIdentifier
    {
        get => new TerraformReference<string>(this, "kms_key_identifier");
        set => SetArgument("kms_key_identifier", value);
    }

    /// <summary>
    /// The location_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationUri is required")]
    public required TerraformValue<string> LocationUri
    {
        get => new TerraformReference<string>(this, "location_uri");
        set => SetArgument("location_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The retrieval_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RetrievalRoleArn
    {
        get => new TerraformReference<string>(this, "retrieval_role_arn");
        set => SetArgument("retrieval_role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The configuration_profile_id attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationProfileId
    {
        get => new TerraformReference<string>(this, "configuration_profile_id");
    }

    /// <summary>
    /// Validator block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 Validator block(s) allowed")]
    public TerraformSet<AwsAppconfigConfigurationProfileValidatorBlock>? Validator
    {
        get => GetArgument<TerraformSet<AwsAppconfigConfigurationProfileValidatorBlock>>("validator");
        set => SetArgument("validator", value);
    }

}
