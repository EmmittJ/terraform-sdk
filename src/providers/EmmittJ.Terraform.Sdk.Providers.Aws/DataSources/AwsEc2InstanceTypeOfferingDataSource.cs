using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2InstanceTypeOfferingDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2InstanceTypeOfferingDataSourceFilterBlock : TerraformBlock
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
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEc2InstanceTypeOfferingDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEc2InstanceTypeOfferingDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_ec2_instance_type_offering Terraform data source.
/// Retrieves information about a aws_ec2_instance_type_offering.
/// </summary>
public partial class AwsEc2InstanceTypeOfferingDataSource(string name) : TerraformDataSource("aws_ec2_instance_type_offering", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location_type attribute.
    /// </summary>
    public TerraformValue<string>? LocationType
    {
        get => GetArgument<TerraformValue<string>>("location_type");
        set => SetArgument("location_type", value);
    }

    /// <summary>
    /// The preferred_instance_types attribute.
    /// </summary>
    public TerraformList<string>? PreferredInstanceTypes
    {
        get => GetArgument<TerraformList<string>>("preferred_instance_types");
        set => SetArgument("preferred_instance_types", value);
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
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
        => CreateReference("instance_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2InstanceTypeOfferingDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2InstanceTypeOfferingDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2InstanceTypeOfferingDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2InstanceTypeOfferingDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
