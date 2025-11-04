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
    public double? CapacityDurationHours
    {
        get => GetProperty<TerraformLiteralProperty<double>>("capacity_duration_hours")?.Value;
        set => this.WithProperty("capacity_duration_hours", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The end_date_range attribute.
    /// </summary>
    public string? EndDateRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_date_range")?.Value;
        set => this.WithProperty("end_date_range", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public double? InstanceCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instance_count")?.Value;
        set => this.WithProperty("instance_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public string? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type")?.Value;
        set => this.WithProperty("instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_date_range attribute.
    /// </summary>
    public string? StartDateRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_date_range")?.Value;
        set => this.WithProperty("start_date_range", value == null ? null : new TerraformLiteralProperty<string>(value));
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
