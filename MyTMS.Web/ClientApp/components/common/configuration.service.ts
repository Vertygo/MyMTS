import Vue from 'vue';
import { injectable } from "inversify";

interface Configuration {
    apiurl: string;
}

@injectable()
export class ConfigurationService extends Vue {
    config: Configuration;

    mounted() {
        fetch('Home/Configuration')
            .then(response => response.json() as Promise<Configuration>)
            .then(data => {
                this.config = data;
            });
    }
}
