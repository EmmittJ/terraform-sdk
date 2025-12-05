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
        get => GetRequiredArgument<TerraformSet<string>>("signing_profile_version_arns");
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
        get => GetRequiredArgument<TerraformValue<string>>("untrusted_artifact_on_deployment");
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
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The config_id attribute.
    /// </summary>
    public TerraformValue<string> ConfigId
        => CreateReference("config_id");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
        => CreateReference("last_modified");

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
