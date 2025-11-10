using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_msk_bootstrap_brokers.
/// </summary>
public class AwsMskBootstrapBrokersDataSource : TerraformDataSource
{
    public AwsMskBootstrapBrokersDataSource(string name) : base("aws_msk_bootstrap_brokers", name)
    {
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    [TerraformPropertyName("cluster_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The bootstrap_brokers attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokers => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers");

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_public_sasl_iam")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersPublicSaslIam => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_public_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_public_sasl_scram")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersPublicSaslScram => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_public_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_public_tls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersPublicTls => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_public_tls");

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_sasl_iam")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersSaslIam => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_sasl_scram")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersSaslScram => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_tls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersTls => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_tls");

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_iam attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_vpc_connectivity_sasl_iam")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersVpcConnectivitySaslIam => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_vpc_connectivity_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_scram attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_vpc_connectivity_sasl_scram")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersVpcConnectivitySaslScram => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_vpc_connectivity_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_tls attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_vpc_connectivity_tls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersVpcConnectivityTls => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_vpc_connectivity_tls");

}
