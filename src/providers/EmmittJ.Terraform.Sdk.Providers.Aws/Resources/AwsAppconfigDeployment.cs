using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_appconfig_deployment Terraform resource.
/// Manages a aws_appconfig_deployment resource.
/// </summary>
public partial class AwsAppconfigDeployment(string name) : TerraformResource("aws_appconfig_deployment", name)
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
    /// The configuration_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationProfileId is required")]
    public required TerraformValue<string> ConfigurationProfileId
    {
        get => new TerraformReference<string>(this, "configuration_profile_id");
        set => SetArgument("configuration_profile_id", value);
    }

    /// <summary>
    /// The configuration_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationVersion is required")]
    public required TerraformValue<string> ConfigurationVersion
    {
        get => new TerraformReference<string>(this, "configuration_version");
        set => SetArgument("configuration_version", value);
    }

    /// <summary>
    /// The deployment_strategy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentStrategyId is required")]
    public required TerraformValue<string> DeploymentStrategyId
    {
        get => new TerraformReference<string>(this, "deployment_strategy_id");
        set => SetArgument("deployment_strategy_id", value);
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
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    public required TerraformValue<string> EnvironmentId
    {
        get => new TerraformReference<string>(this, "environment_id");
        set => SetArgument("environment_id", value);
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
    /// The deployment_number attribute.
    /// </summary>
    public TerraformValue<double> DeploymentNumber
    {
        get => new TerraformReference<double>(this, "deployment_number");
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

}
