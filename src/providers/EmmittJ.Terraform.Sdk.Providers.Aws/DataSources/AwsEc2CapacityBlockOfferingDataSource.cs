using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ec2_capacity_block_offering Terraform data source.
/// Retrieves information about a aws_ec2_capacity_block_offering.
/// </summary>
public partial class AwsEc2CapacityBlockOfferingDataSource(string name) : TerraformDataSource("aws_ec2_capacity_block_offering", name)
{
    /// <summary>
    /// The capacity_duration_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityDurationHours is required")]
    public required TerraformValue<double> CapacityDurationHours
    {
        get => GetRequiredArgument<TerraformValue<double>>("capacity_duration_hours");
        set => SetArgument("capacity_duration_hours", value);
    }

    /// <summary>
    /// The end_date_range attribute.
    /// </summary>
    public TerraformValue<string> EndDateRange
    {
        get => GetArgument<TerraformValue<string>>("end_date_range") ?? CreateReference("end_date_range");
        set => SetArgument("end_date_range", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    public required TerraformValue<double> InstanceCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
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
    /// The start_date_range attribute.
    /// </summary>
    public TerraformValue<string> StartDateRange
    {
        get => GetArgument<TerraformValue<string>>("start_date_range") ?? CreateReference("start_date_range");
        set => SetArgument("start_date_range", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => CreateReference("availability_zone");

    /// <summary>
    /// The capacity_block_offering_id attribute.
    /// </summary>
    public TerraformValue<string> CapacityBlockOfferingId
        => CreateReference("capacity_block_offering_id");

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    public TerraformValue<string> CurrencyCode
        => CreateReference("currency_code");

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformValue<string> Tenancy
        => CreateReference("tenancy");

    /// <summary>
    /// The upfront_fee attribute.
    /// </summary>
    public TerraformValue<string> UpfrontFee
        => CreateReference("upfront_fee");

}
