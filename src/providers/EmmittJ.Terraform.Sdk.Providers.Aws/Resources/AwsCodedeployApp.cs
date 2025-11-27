using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_codedeploy_app Terraform resource.
/// Manages a aws_codedeploy_app resource.
/// </summary>
public partial class AwsCodedeployApp(string name) : TerraformResource("aws_codedeploy_app", name)
{
    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    public TerraformValue<string>? ComputePlatform
    {
        get => new TerraformReference<string>(this, "compute_platform");
        set => SetArgument("compute_platform", value);
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
    /// The application_id attribute.
    /// </summary>
    public TerraformValue<string> ApplicationId
    {
        get => new TerraformReference<string>(this, "application_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The github_account_name attribute.
    /// </summary>
    public TerraformValue<string> GithubAccountName
    {
        get => new TerraformReference<string>(this, "github_account_name");
    }

    /// <summary>
    /// The linked_to_github attribute.
    /// </summary>
    public TerraformValue<bool> LinkedToGithub
    {
        get => new TerraformReference<bool>(this, "linked_to_github");
    }

}
