using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for entry in AwsEc2ManagedPrefixList.
/// Nesting mode: set
/// </summary>
public class AwsEc2ManagedPrefixListEntryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "entry";

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    public required TerraformValue<string> Cidr
    {
        get => new TerraformReference<string>(this, "cidr");
        set => SetArgument("cidr", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

}


/// <summary>
/// Represents a aws_ec2_managed_prefix_list Terraform resource.
/// Manages a aws_ec2_managed_prefix_list resource.
/// </summary>
public partial class AwsEc2ManagedPrefixList(string name) : TerraformResource("aws_ec2_managed_prefix_list", name)
{
    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    public required TerraformValue<string> AddressFamily
    {
        get => new TerraformReference<string>(this, "address_family");
        set => SetArgument("address_family", value);
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
    /// The max_entries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxEntries is required")]
    public required TerraformValue<double> MaxEntries
    {
        get => new TerraformReference<double>(this, "max_entries");
        set => SetArgument("max_entries", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
    {
        get => new TerraformReference<double>(this, "version");
    }

    /// <summary>
    /// Entry block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2ManagedPrefixListEntryBlock>? Entry
    {
        get => GetArgument<TerraformSet<AwsEc2ManagedPrefixListEntryBlock>>("entry");
        set => SetArgument("entry", value);
    }

}
