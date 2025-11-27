using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for allowed_publishers in AwsLambdaCodeSigningConfig.
/// Nesting mode: list
/// </summary>
public class AwsLambdaCodeSigningConfigAllowedPublishersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_publishers";

    /// <summary>
    /// The signing_profile_version_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningProfileVersionArns is required")]
    public required TerraformSet<string> SigningProfileVersionArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "signing_profile_version_arns").ResolveNodes(ctx));
        set => SetArgument("signing_profile_version_arns", value);
    }

}


/// <summary>
/// Block type for policies in AwsLambdaCodeSigningConfig.
/// Nesting mode: list
/// </summary>
public class AwsLambdaCodeSigningConfigPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policies";

    /// <summary>
    /// The untrusted_artifact_on_deployment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UntrustedArtifactOnDeployment is required")]
    public required TerraformValue<string> UntrustedArtifactOnDeployment
    {
        get => new TerraformReference<string>(this, "untrusted_artifact_on_deployment");
        set => SetArgument("untrusted_artifact_on_deployment", value);
    }

}


/// <summary>
/// Represents a aws_lambda_code_signing_config Terraform resource.
/// Manages a aws_lambda_code_signing_config resource.
/// </summary>
public partial class AwsLambdaCodeSigningConfig(string name) : TerraformResource("aws_lambda_code_signing_config", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The config_id attribute.
    /// </summary>
    public TerraformValue<string> ConfigId
    {
        get => new TerraformReference<string>(this, "config_id");
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
    {
        get => new TerraformReference<string>(this, "last_modified");
    }

    /// <summary>
    /// AllowedPublishers block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedPublishers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AllowedPublishers block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowedPublishers block(s) allowed")]
    public required TerraformList<AwsLambdaCodeSigningConfigAllowedPublishersBlock> AllowedPublishers
    {
        get => GetRequiredArgument<TerraformList<AwsLambdaCodeSigningConfigAllowedPublishersBlock>>("allowed_publishers");
        set => SetArgument("allowed_publishers", value);
    }

    /// <summary>
    /// Policies block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Policies block(s) allowed")]
    public TerraformList<AwsLambdaCodeSigningConfigPoliciesBlock>? Policies
    {
        get => GetArgument<TerraformList<AwsLambdaCodeSigningConfigPoliciesBlock>>("policies");
        set => SetArgument("policies", value);
    }

}
