using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_msk_bootstrap_brokers.
/// </summary>
public class AwsMskBootstrapBrokersDataSource : TerraformDataSource
{
    public AwsMskBootstrapBrokersDataSource(string name) : base("aws_msk_bootstrap_brokers", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("bootstrap_brokers");
        this.DeclareOutput("bootstrap_brokers_public_sasl_iam");
        this.DeclareOutput("bootstrap_brokers_public_sasl_scram");
        this.DeclareOutput("bootstrap_brokers_public_tls");
        this.DeclareOutput("bootstrap_brokers_sasl_iam");
        this.DeclareOutput("bootstrap_brokers_sasl_scram");
        this.DeclareOutput("bootstrap_brokers_tls");
        this.DeclareOutput("bootstrap_brokers_vpc_connectivity_sasl_iam");
        this.DeclareOutput("bootstrap_brokers_vpc_connectivity_sasl_scram");
        this.DeclareOutput("bootstrap_brokers_vpc_connectivity_tls");
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    public string? ClusterArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_arn")?.Value;
        set => this.WithProperty("cluster_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The bootstrap_brokers attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokers => this["bootstrap_brokers"];

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersPublicSaslIam => this["bootstrap_brokers_public_sasl_iam"];

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersPublicSaslScram => this["bootstrap_brokers_public_sasl_scram"];

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersPublicTls => this["bootstrap_brokers_public_tls"];

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersSaslIam => this["bootstrap_brokers_sasl_iam"];

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersSaslScram => this["bootstrap_brokers_sasl_scram"];

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersTls => this["bootstrap_brokers_tls"];

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_iam attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersVpcConnectivitySaslIam => this["bootstrap_brokers_vpc_connectivity_sasl_iam"];

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_scram attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersVpcConnectivitySaslScram => this["bootstrap_brokers_vpc_connectivity_sasl_scram"];

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_tls attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersVpcConnectivityTls => this["bootstrap_brokers_vpc_connectivity_tls"];

}
