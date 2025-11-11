using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_msk_bootstrap_brokers.
/// </summary>
public partial class AwsMskBootstrapBrokersDataSource : TerraformDataSource
{
    public AwsMskBootstrapBrokersDataSource(string name) : base("aws_msk_bootstrap_brokers", name)
    {
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    [TerraformProperty("cluster_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The bootstrap_brokers attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokers { get; }

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_public_sasl_iam")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersPublicSaslIam { get; }

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_public_sasl_scram")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersPublicSaslScram { get; }

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_public_tls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersPublicTls { get; }

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_sasl_iam")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersSaslIam { get; }

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_sasl_scram")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersSaslScram { get; }

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_tls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersTls { get; }

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_iam attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_vpc_connectivity_sasl_iam")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersVpcConnectivitySaslIam { get; }

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_scram attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_vpc_connectivity_sasl_scram")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersVpcConnectivitySaslScram { get; }

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_tls attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_vpc_connectivity_tls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersVpcConnectivityTls { get; }

}
