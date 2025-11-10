using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_capacity_block_offering.
/// </summary>
public class AwsEc2CapacityBlockOfferingDataSource : TerraformDataSource
{
    public AwsEc2CapacityBlockOfferingDataSource(string name) : base("aws_ec2_capacity_block_offering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("capacity_block_offering_id");
        this.DeclareOutput("currency_code");
        this.DeclareOutput("tenancy");
        this.DeclareOutput("upfront_fee");
    }

    /// <summary>
    /// The capacity_duration_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityDurationHours is required")]
    public required TerraformProperty<double> CapacityDurationHours
    {
        get => GetProperty<TerraformProperty<double>>("capacity_duration_hours");
        set => this.WithProperty("capacity_duration_hours", value);
    }

    /// <summary>
    /// The end_date_range attribute.
    /// </summary>
    public TerraformProperty<string>? EndDateRange
    {
        get => GetProperty<TerraformProperty<string>>("end_date_range");
        set => this.WithProperty("end_date_range", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    public required TerraformProperty<double> InstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_count");
        set => this.WithProperty("instance_count", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The start_date_range attribute.
    /// </summary>
    public TerraformProperty<string>? StartDateRange
    {
        get => GetProperty<TerraformProperty<string>>("start_date_range");
        set => this.WithProperty("start_date_range", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The capacity_block_offering_id attribute.
    /// </summary>
    public TerraformExpression CapacityBlockOfferingId => this["capacity_block_offering_id"];

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    public TerraformExpression CurrencyCode => this["currency_code"];

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformExpression Tenancy => this["tenancy"];

    /// <summary>
    /// The upfront_fee attribute.
    /// </summary>
    public TerraformExpression UpfrontFee => this["upfront_fee"];

}
