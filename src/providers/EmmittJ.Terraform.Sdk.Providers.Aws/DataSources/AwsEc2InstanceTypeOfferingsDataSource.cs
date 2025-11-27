using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2InstanceTypeOfferingsDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2InstanceTypeOfferingsDataSourceFilterBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEc2InstanceTypeOfferingsDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEc2InstanceTypeOfferingsDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_ec2_instance_type_offerings Terraform data source.
/// Retrieves information about a aws_ec2_instance_type_offerings.
/// </summary>
public partial class AwsEc2InstanceTypeOfferingsDataSource(string name) : TerraformDataSource("aws_ec2_instance_type_offerings", name)
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
    /// The location_type attribute.
    /// </summary>
    public TerraformValue<string>? LocationType
    {
        get => new TerraformReference<string>(this, "location_type");
        set => SetArgument("location_type", value);
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
    /// The instance_types attribute.
    /// </summary>
    public TerraformList<string> InstanceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "instance_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location_types attribute.
    /// </summary>
    public TerraformList<string> LocationTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "location_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The locations attribute.
    /// </summary>
    public TerraformList<string> Locations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "locations").ResolveNodes(ctx));
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2InstanceTypeOfferingsDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2InstanceTypeOfferingsDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2InstanceTypeOfferingsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2InstanceTypeOfferingsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
