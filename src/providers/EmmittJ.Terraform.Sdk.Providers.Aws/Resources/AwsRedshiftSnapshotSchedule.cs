using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_snapshot_schedule Terraform resource.
/// Manages a aws_redshift_snapshot_schedule resource.
/// </summary>
public partial class AwsRedshiftSnapshotSchedule(string name) : TerraformResource("aws_redshift_snapshot_schedule", name)
{
    /// <summary>
    /// The definitions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Definitions is required")]
    public required TerraformSet<string> Definitions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "definitions").ResolveNodes(ctx));
        set => SetArgument("definitions", value);
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
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
        set => SetArgument("force_destroy", value);
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
    /// The identifier attribute.
    /// </summary>
    public TerraformValue<string> Identifier
    {
        get => new TerraformReference<string>(this, "identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public TerraformValue<string> IdentifierPrefix
    {
        get => new TerraformReference<string>(this, "identifier_prefix");
        set => SetArgument("identifier_prefix", value);
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

}
