using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_msk_bootstrap_brokers Terraform data source.
/// Retrieves information about a aws_msk_bootstrap_brokers.
/// </summary>
public partial class AwsMskBootstrapBrokersDataSource(string name) : TerraformDataSource("aws_msk_bootstrap_brokers", name)
{
    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    public required TerraformValue<string> ClusterArn
    {
        get => new TerraformReference<string>(this, "cluster_arn");
        set => SetArgument("cluster_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The bootstrap_brokers attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokers
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers");
    }

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicSaslIam
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_public_sasl_iam");
    }

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicSaslScram
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_public_sasl_scram");
    }

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicTls
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_public_tls");
    }

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersSaslIam
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_sasl_iam");
    }

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersSaslScram
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_sasl_scram");
    }

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersTls
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_tls");
    }

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersVpcConnectivitySaslIam
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_vpc_connectivity_sasl_iam");
    }

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_scram attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersVpcConnectivitySaslScram
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_vpc_connectivity_sasl_scram");
    }

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_tls attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersVpcConnectivityTls
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_vpc_connectivity_tls");
    }

}
