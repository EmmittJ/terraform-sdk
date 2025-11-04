using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_db_servers.
/// </summary>
public class AwsOdbDbServersDataSource : TerraformDataSource
{
    public AwsOdbDbServersDataSource(string name) : base("aws_odb_db_servers", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("db_servers");
    }

    /// <summary>
    /// The cloud exadata infrastructure ID. Mandatory field.
    /// </summary>
    public string? CloudExadataInfrastructureId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_exadata_infrastructure_id")?.Value;
        set => this.WithProperty("cloud_exadata_infrastructure_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// List of database servers associated with cloud_exadata_infrastructure_id.
    /// </summary>
    public TerraformExpression DbServers => this["db_servers"];

}
