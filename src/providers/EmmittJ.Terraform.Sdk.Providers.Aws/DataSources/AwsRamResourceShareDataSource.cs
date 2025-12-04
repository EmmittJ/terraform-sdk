using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsRamResourceShareDataSource.
/// Nesting mode: set
/// </summary>
public class AwsRamResourceShareDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_ram_resource_share Terraform data source.
/// Retrieves information about a aws_ram_resource_share.
/// </summary>
public partial class AwsRamResourceShareDataSource(string name) : TerraformDataSource("aws_ram_resource_share", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceOwner is required")]
    public required TerraformValue<string> ResourceOwner
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_owner");
        set => SetArgument("resource_owner", value);
    }

    /// <summary>
    /// The resource_share_status attribute.
    /// </summary>
    public TerraformValue<string>? ResourceShareStatus
    {
        get => GetArgument<TerraformValue<string>>("resource_share_status");
        set => SetArgument("resource_share_status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The owning_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwningAccountId
        => AsReference("owning_account_id");

    /// <summary>
    /// The resource_arns attribute.
    /// </summary>
    public TerraformList<string> ResourceArns
        => AsReference("resource_arns");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRamResourceShareDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsRamResourceShareDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
