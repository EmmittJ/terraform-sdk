using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rds_reserved_instance resource.
/// </summary>
public class AwsRdsReservedInstance : TerraformResource
{
    public AwsRdsReservedInstance(string name) : base("aws_rds_reserved_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("currency_code");
        this.DeclareOutput("db_instance_class");
        this.DeclareOutput("duration");
        this.DeclareOutput("fixed_price");
        this.DeclareOutput("lease_id");
        this.DeclareOutput("multi_az");
        this.DeclareOutput("offering_type");
        this.DeclareOutput("product_description");
        this.DeclareOutput("recurring_charges");
        this.DeclareOutput("start_time");
        this.DeclareOutput("state");
        this.DeclareOutput("usage_price");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The offering_id attribute.
    /// </summary>
    public string? OfferingId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("offering_id")?.Value;
        set => this.WithProperty("offering_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reservation_id attribute.
    /// </summary>
    public string? ReservationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reservation_id")?.Value;
        set => this.WithProperty("reservation_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    public TerraformExpression CurrencyCode => this["currency_code"];

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    public TerraformExpression DbInstanceClass => this["db_instance_class"];

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformExpression Duration => this["duration"];

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    public TerraformExpression FixedPrice => this["fixed_price"];

    /// <summary>
    /// The lease_id attribute.
    /// </summary>
    public TerraformExpression LeaseId => this["lease_id"];

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformExpression MultiAz => this["multi_az"];

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    public TerraformExpression OfferingType => this["offering_type"];

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    public TerraformExpression ProductDescription => this["product_description"];

    /// <summary>
    /// The recurring_charges attribute.
    /// </summary>
    public TerraformExpression RecurringCharges => this["recurring_charges"];

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformExpression StartTime => this["start_time"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The usage_price attribute.
    /// </summary>
    public TerraformExpression UsagePrice => this["usage_price"];

}
