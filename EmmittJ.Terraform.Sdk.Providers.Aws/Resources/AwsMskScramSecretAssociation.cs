using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_msk_scram_secret_association resource.
/// </summary>
public class AwsMskScramSecretAssociation : TerraformResource
{
    public AwsMskScramSecretAssociation(string name) : base("aws_msk_scram_secret_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The secret_arn_list attribute.
    /// </summary>
    public HashSet<string>? SecretArnList
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("secret_arn_list")?.Value;
        set => this.WithProperty("secret_arn_list", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
