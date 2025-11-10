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
        SetOutput("db_servers");
        SetOutput("cloud_exadata_infrastructure_id");
        SetOutput("region");
    }

    /// <summary>
    /// The cloud exadata infrastructure ID. Mandatory field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformProperty<string> CloudExadataInfrastructureId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_exadata_infrastructure_id");
        set => SetProperty("cloud_exadata_infrastructure_id", value);
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
    /// List of database servers associated with cloud_exadata_infrastructure_id.
    /// </summary>
    public TerraformExpression DbServers => this["db_servers"];

}
