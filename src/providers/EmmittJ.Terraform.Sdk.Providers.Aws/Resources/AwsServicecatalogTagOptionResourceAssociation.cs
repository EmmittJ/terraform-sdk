using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsServicecatalogTagOptionResourceAssociation.
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogTagOptionResourceAssociationTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_servicecatalog_tag_option_resource_association Terraform resource.
/// Manages a aws_servicecatalog_tag_option_resource_association resource.
/// </summary>
public partial class AwsServicecatalogTagOptionResourceAssociation(string name) : TerraformResource("aws_servicecatalog_tag_option_resource_association", name)
{
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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The tag_option_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagOptionId is required")]
    public required TerraformValue<string> TagOptionId
    {
        get => new TerraformReference<string>(this, "tag_option_id");
        set => SetArgument("tag_option_id", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
    }

    /// <summary>
    /// The resource_created_time attribute.
    /// </summary>
    public TerraformValue<string> ResourceCreatedTime
    {
        get => new TerraformReference<string>(this, "resource_created_time");
    }

    /// <summary>
    /// The resource_description attribute.
    /// </summary>
    public TerraformValue<string> ResourceDescription
    {
        get => new TerraformReference<string>(this, "resource_description");
    }

    /// <summary>
    /// The resource_name attribute.
    /// </summary>
    public TerraformValue<string> ResourceName
    {
        get => new TerraformReference<string>(this, "resource_name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsServicecatalogTagOptionResourceAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsServicecatalogTagOptionResourceAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
