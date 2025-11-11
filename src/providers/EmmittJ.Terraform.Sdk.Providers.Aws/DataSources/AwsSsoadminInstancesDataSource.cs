using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssoadmin_instances.
/// </summary>
public partial class AwsSsoadminInstancesDataSource : TerraformDataSource
{
    public AwsSsoadminInstancesDataSource(string name) : base("aws_ssoadmin_instances", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformProperty("arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Arns { get; }

    /// <summary>
    /// The identity_store_ids attribute.
    /// </summary>
    [TerraformProperty("identity_store_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> IdentityStoreIds { get; }

}
