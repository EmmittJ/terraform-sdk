using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_reserved_instance_offering.
/// </summary>
public partial class AwsRdsReservedInstanceOfferingDataSource : TerraformDataSource
{
    public AwsRdsReservedInstanceOfferingDataSource(string name) : base("aws_rds_reserved_instance_offering", name)
    {
    }

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbInstanceClass is required")]
    [TerraformProperty("db_instance_class")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DbInstanceClass { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformProperty("duration")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Duration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MultiAz is required")]
    [TerraformProperty("multi_az")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> MultiAz { get; set; }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingType is required")]
    [TerraformProperty("offering_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OfferingType { get; set; }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductDescription is required")]
    [TerraformProperty("product_description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProductDescription { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    [TerraformProperty("currency_code")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CurrencyCode { get; }

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    [TerraformProperty("fixed_price")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> FixedPrice { get; }

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    [TerraformProperty("offering_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OfferingId { get; }

}
