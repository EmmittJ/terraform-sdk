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
        get => GetRequiredArgument<TerraformValue<string>>("cluster_arn");
        set => SetArgument("cluster_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The bootstrap_brokers attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokers
        => AsReference("bootstrap_brokers");

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicSaslIam
        => AsReference("bootstrap_brokers_public_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicSaslScram
        => AsReference("bootstrap_brokers_public_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicTls
        => AsReference("bootstrap_brokers_public_tls");

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersSaslIam
        => AsReference("bootstrap_brokers_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersSaslScram
        => AsReference("bootstrap_brokers_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersTls
        => AsReference("bootstrap_brokers_tls");

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersVpcConnectivitySaslIam
        => AsReference("bootstrap_brokers_vpc_connectivity_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_scram attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersVpcConnectivitySaslScram
        => AsReference("bootstrap_brokers_vpc_connectivity_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_tls attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersVpcConnectivityTls
        => AsReference("bootstrap_brokers_vpc_connectivity_tls");

}
