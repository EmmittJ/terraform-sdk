using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsKendraExperience.
/// Nesting mode: list
/// </summary>
public class AwsKendraExperienceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// ContentSourceConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentSourceConfiguration block(s) allowed")]
    public TerraformList<AwsKendraExperienceConfigurationBlockContentSourceConfigurationBlock>? ContentSourceConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraExperienceConfigurationBlockContentSourceConfigurationBlock>>("content_source_configuration");
        set => SetArgument("content_source_configuration", value);
    }

    /// <summary>
    /// UserIdentityConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserIdentityConfiguration block(s) allowed")]
    public TerraformList<AwsKendraExperienceConfigurationBlockUserIdentityConfigurationBlock>? UserIdentityConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraExperienceConfigurationBlockUserIdentityConfigurationBlock>>("user_identity_configuration");
        set => SetArgument("user_identity_configuration", value);
    }

}

/// <summary>
/// Block type for content_source_configuration in AwsKendraExperienceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraExperienceConfigurationBlockContentSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "content_source_configuration";

    /// <summary>
    /// The data_source_ids attribute.
    /// </summary>
    public TerraformSet<string>? DataSourceIds
    {
        get => GetArgument<TerraformSet<string>>("data_source_ids");
        set => SetArgument("data_source_ids", value);
    }

    /// <summary>
    /// The direct_put_content attribute.
    /// </summary>
    public TerraformValue<bool>? DirectPutContent
    {
        get => GetArgument<TerraformValue<bool>>("direct_put_content");
        set => SetArgument("direct_put_content", value);
    }

    /// <summary>
    /// The faq_ids attribute.
    /// </summary>
    public TerraformSet<string>? FaqIds
    {
        get => GetArgument<TerraformSet<string>>("faq_ids");
        set => SetArgument("faq_ids", value);
    }

}

/// <summary>
/// Block type for user_identity_configuration in AwsKendraExperienceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraExperienceConfigurationBlockUserIdentityConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_identity_configuration";

    /// <summary>
    /// The identity_attribute_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityAttributeName is required")]
    public required TerraformValue<string> IdentityAttributeName
    {
        get => GetRequiredArgument<TerraformValue<string>>("identity_attribute_name");
        set => SetArgument("identity_attribute_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsKendraExperience.
/// Nesting mode: single
/// </summary>
public class AwsKendraExperienceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_kendra_experience Terraform resource.
/// Manages a aws_kendra_experience resource.
/// </summary>
public partial class AwsKendraExperience(string name) : TerraformResource("aws_kendra_experience", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The index_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexId is required")]
    public required TerraformValue<string> IndexId
    {
        get => GetRequiredArgument<TerraformValue<string>>("index_id");
        set => SetArgument("index_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Endpoints
        => AsReference("endpoints");

    /// <summary>
    /// The experience_id attribute.
    /// </summary>
    public TerraformValue<string> ExperienceId
        => AsReference("experience_id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public TerraformList<AwsKendraExperienceConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsKendraExperienceConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsKendraExperienceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsKendraExperienceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
