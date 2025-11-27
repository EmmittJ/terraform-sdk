using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lambda_code_signing_config Terraform data source.
/// Retrieves information about a aws_lambda_code_signing_config.
/// </summary>
public partial class AwsLambdaCodeSigningConfigDataSource(string name) : TerraformDataSource("aws_lambda_code_signing_config", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
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
    /// The allowed_publishers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AllowedPublishers
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "allowed_publishers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The config_id attribute.
    /// </summary>
    public TerraformValue<string> ConfigId
    {
        get => new TerraformReference<string>(this, "config_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
    {
        get => new TerraformReference<string>(this, "last_modified");
    }

    /// <summary>
    /// The policies attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Policies
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "policies").ResolveNodes(ctx));
    }

}
