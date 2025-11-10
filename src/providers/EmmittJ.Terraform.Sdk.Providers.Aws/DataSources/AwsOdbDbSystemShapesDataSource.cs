using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_db_system_shapes.
/// </summary>
public class AwsOdbDbSystemShapesDataSource : TerraformDataSource
{
    public AwsOdbDbSystemShapesDataSource(string name) : base("aws_odb_db_system_shapes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("db_system_shapes");
    }

    /// <summary>
    /// The physical ID of the AZ, for example, use1-az4. This ID persists across accounts.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZoneId
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone_id");
        set => this.WithProperty("availability_zone_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The list of shapes and their properties. Information about a hardware system model (shape) that&#39;s available for an Exadata infrastructure.The shape determines resources, such as CPU cores, memory, and storage, to allocate to the Exadata infrastructure.
    /// </summary>
    public TerraformExpression DbSystemShapes => this["db_system_shapes"];

}
