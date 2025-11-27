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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "data_source_ids").ResolveNodes(ctx));
        set => SetArgument("data_source_ids", value);
    }

    /// <summary>
    /// The direct_put_content attribute.
    /// </summary>
    public TerraformValue<bool>? DirectPutContent
    {
        get => new TerraformReference<bool>(this, "direct_put_content");
        set => SetArgument("direct_put_content", value);
    }

    /// <summary>
    /// The faq_ids attribute.
    /// </summary>
    public TerraformSet<string>? FaqIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "faq_ids").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "identity_attribute_name");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
    /// The index_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexId is required")]
    public required TerraformValue<string> IndexId
    {
        get => new TerraformReference<string>(this, "index_id");
        set => SetArgument("index_id", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Endpoints
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// The experience_id attribute.
    /// </summary>
    public TerraformValue<string> ExperienceId
    {
        get => new TerraformReference<string>(this, "experience_id");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

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
