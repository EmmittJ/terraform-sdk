using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_reserved_instance_offering.
/// </summary>
public class AwsRdsReservedInstanceOfferingDataSource : TerraformDataSource
{
    public AwsRdsReservedInstanceOfferingDataSource(string name) : base("aws_rds_reserved_instance_offering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("currency_code");
        this.DeclareOutput("fixed_price");
        this.DeclareOutput("offering_id");
    }

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    public TerraformProperty<string>? DbInstanceClass
    {
        get => GetProperty<TerraformProperty<string>>("db_instance_class");
        set => this.WithProperty("db_instance_class", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformProperty<double>? Duration
    {
        get => GetProperty<TerraformProperty<double>>("duration");
        set => this.WithProperty("duration", value);
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
    /// The multi_az attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiAz
    {
        get => GetProperty<TerraformProperty<bool>>("multi_az");
        set => this.WithProperty("multi_az", value);
    }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    public TerraformProperty<string>? OfferingType
    {
        get => GetProperty<TerraformProperty<string>>("offering_type");
        set => this.WithProperty("offering_type", value);
    }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    public TerraformProperty<string>? ProductDescription
    {
        get => GetProperty<TerraformProperty<string>>("product_description");
        set => this.WithProperty("product_description", value);
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
    /// The currency_code attribute.
    /// </summary>
    public TerraformExpression CurrencyCode => this["currency_code"];

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    public TerraformExpression FixedPrice => this["fixed_price"];

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    public TerraformExpression OfferingId => this["offering_id"];

}
