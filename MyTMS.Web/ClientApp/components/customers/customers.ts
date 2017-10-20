import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import { ConfigurationService } from '../common/configuration.service';

@Component
export default class CustomerComponent extends Vue {
    currentcount: number = 0;

    incrementCounter() {
        
        this.currentcount++;
    }
}
