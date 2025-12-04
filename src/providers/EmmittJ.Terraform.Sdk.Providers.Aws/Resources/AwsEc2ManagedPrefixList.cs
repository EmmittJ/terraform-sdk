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
        get => GetArgument<TerraformValue<string>>("cidr");
        set => SetArgument("cidr", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
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
        get => GetArgument<TerraformValue<string>>("address_family");
        set => SetArgument("address_family", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_entries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxEntries is required")]
    public required TerraformValue<double> MaxEntries
    {
        get => GetArgument<TerraformValue<double>>("max_entries");
        set => SetArgument("max_entries", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
        => AsReference("version");

    /// <summary>
    /// Entry block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2ManagedPrefixListEntryBlock>? Entry
    {
        get => GetArgument<TerraformSet<AwsEc2ManagedPrefixListEntryBlock>>("entry");
        set => SetArgument("entry", value);
    }

}
