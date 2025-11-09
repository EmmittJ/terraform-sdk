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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_count");
        set => this.WithProperty("instance_count", value);
    }

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    public TerraformProperty<string>? OfferingId
    {
        get => GetProperty<TerraformProperty<string>>("offering_id");
        set => this.WithProperty("offering_id", value);
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
    /// The reservation_id attribute.
    /// </summary>
    public TerraformProperty<string>? ReservationId
    {
        get => GetProperty<TerraformProperty<string>>("reservation_id");
        set => this.WithProperty("reservation_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
