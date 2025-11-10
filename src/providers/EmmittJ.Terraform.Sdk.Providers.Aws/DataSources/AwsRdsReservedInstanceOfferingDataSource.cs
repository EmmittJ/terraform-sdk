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
        SetOutput("currency_code");
        SetOutput("fixed_price");
        SetOutput("offering_id");
        SetOutput("db_instance_class");
        SetOutput("duration");
        SetOutput("id");
        SetOutput("multi_az");
        SetOutput("offering_type");
        SetOutput("product_description");
        SetOutput("region");
    }

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbInstanceClass is required")]
    public required TerraformProperty<string> DbInstanceClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_instance_class");
        set => SetProperty("db_instance_class", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformProperty<double> Duration
    {
        get => GetRequiredOutput<TerraformProperty<double>>("duration");
        set => SetProperty("duration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MultiAz is required")]
    public required TerraformProperty<bool> MultiAz
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multi_az");
        set => SetProperty("multi_az", value);
    }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingType is required")]
    public required TerraformProperty<string> OfferingType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("offering_type");
        set => SetProperty("offering_type", value);
    }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductDescription is required")]
    public required TerraformProperty<string> ProductDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("product_description");
        set => SetProperty("product_description", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
